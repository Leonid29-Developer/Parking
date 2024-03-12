using System;
using System.Drawing;
using System.Windows.Forms;

namespace Test135
{
    public partial class FormParking : Form
    {
        /// <summary> Объект от класса многоуровневой парковки </summary>
        MultiLevelParking parking;

        /// <summary> Количество уровней-парковок </summary>
        private const int countLevel = 6;

        public FormParking()
        { InitializeComponent(); NewDraw(); }

        ///<summary> Обработка изменения размера формы </summary>
        private void FormParking_Resize(object sender, EventArgs e)
        {
            if (Width > 160 & Height > 30)
            {
                for (int i = 0; i < countLevel; i++)
                {
                    parking[i].Resize(new Size(pictureBoxParking.Width, pictureBoxParking.Height));
                    _ = parking[i] ^ 1;
                }
                Draw();
            }
        }

        /// <summary> Метод. Отрисовка парковки </summary>
        private void NewDraw()
        {
            parking = new MultiLevelParking(countLevel, new Size(pictureBoxParking.Width, pictureBoxParking.Height));

            // Заполнение listBox
            for (int i = 0; i < countLevel; i++)
                ListLevels.Items.Add("Уровень " + (i + 1));
            ListLevels.SelectedIndex = 0;

            Draw();
        }

        /// <summary> Метод. отрисовка парковки </summary>
        private void Draw()
        {
            if (ListLevels.SelectedIndex > -1)
            {
                Bitmap bmp = new Bitmap(pictureBoxParking.Width, pictureBoxParking.Height);
                Graphics gr = Graphics.FromImage(bmp);
                parking[ListLevels.SelectedIndex].Draw(gr); pictureBoxParking.Image = bmp;
            }
        }

        /// <summary> Обработка нажатия кнопки "Припарковать автомобиль" </summary>
        private void buttonSetCar_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var car = new Car(Transports.Car, 100, 1000, dialog.Color);
                _ = parking[ListLevels.SelectedIndex] + car; Draw();
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
                    _ = parking[ListLevels.SelectedIndex] + car; Draw();
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
                _ = parking[ListLevels.SelectedIndex] + car; Draw();
            }
        }

        /// <summary> Обработка нажатия кнопки "Забрать" </summary>
        private void buttonTakeCar_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                var car = parking[ListLevels.SelectedIndex] - Convert.ToInt32(textBox1.Text);
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

        private void ListLevels_SelectedIndexChanged(object sender, EventArgs e) => Draw();
    }
}