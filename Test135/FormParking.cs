using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Test135
{
    public partial class FormParking : Form
    {
        /// <summary> Объект от класса-парковки </summary>
        Parking<ITransport> parking;

        public FormParking()
        { InitializeComponent(); NewDraw(); }

        ///<summary> Обработка изменения размера формы </summary>
        private void FormParking_Resize(object sender, EventArgs e)
        {
            if (Width > 160 & Height > 30)
            {
                parking.Resize(new Size(pictureBoxParking.Width, pictureBoxParking.Height));
                _ = parking ^ 1; Draw();
            }
        }

        /// <summary> Метод. Отрисовка парковки </summary>
        private void NewDraw()
        {
            parking = new Parking<ITransport>(new Size(pictureBoxParking.Width, pictureBoxParking.Height));
                Draw();
        }

        /// <summary> Метод. отрисовка парковки </summary>
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxParking.Width, pictureBoxParking.Height);
                Graphics gr = Graphics.FromImage(bmp);
                parking.Draw(gr); pictureBoxParking.Image = bmp;
        }

        /// <summary> Обработка нажатия кнопки "Припарковать автомобиль" </summary>
        private void buttonSetCar_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var car = new Car(Transports.Car, 100, 1000, dialog.Color);
                _ = parking + car; Draw();
            }
        }

        /// <summary> Обработка нажатия кнопки "Припарковать гоночный автомобиль" </summary>
        private void buttonSetSportCar_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ColorDialog dialogDop = new ColorDialog();
                if (dialogDop.ShowDialog() == DialogResult.OK)
                {
                    Random Rand = new Random();
                    var car = new SportCar(Transports.SportCar, 100, 1000, dialog.Color, dialogDop.Color, Rand.Next(1, 4), Color.White);
                    _ = parking + car; Draw();
                }
            }
        }

        /// <summary> Обработка нажатия кнопки "Припарковать крейсер" </summary>
        private void buttonSetCruiser_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Bitmap BM_Flag = new Bitmap(15, 9); Graphics Grap_Flag = Graphics.FromImage(BM_Flag);

                Grap_Flag.FillRectangle(new SolidBrush(Color.White), 0, 0, 15, 3);
                Grap_Flag.FillRectangle(new SolidBrush(Color.Blue), 0, 3, 15, 3);
                Grap_Flag.FillRectangle(new SolidBrush(Color.Red), 0, 6, 15, 3);
                Grap_Flag.FillRectangle(new SolidBrush(Color.Gold), 10, 3, 3, 3);

                var car = new Cruiser(Transports.Cruiser, 100, 1000, dialog.Color, BM_Flag);
                _ = parking + car; Draw();
            }
        }

        /// <summary> Обработка нажатия кнопки "Забрать" </summary>
        private void buttonTakeCar_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                var car = parking - Convert.ToInt32(textBox1.Text);
                if (car != null)
                {
                    Bitmap bmp = new Bitmap(pictureBoxTakeCar.Width, pictureBoxTakeCar.Height);
                    Graphics gr = Graphics.FromImage(bmp);
                    car.SetPosition(new Point(5, 5), new Size(pictureBoxTakeCar.Width, pictureBoxTakeCar.Height));
                    car.Draw(gr); pictureBoxTakeCar.Image = bmp;
                }
                else
                {
                    Bitmap bmp = new Bitmap(pictureBoxTakeCar.Width, pictureBoxTakeCar.Height);
                    pictureBoxTakeCar.Image = bmp;
                }
                Draw();
            }
        }
    }
}