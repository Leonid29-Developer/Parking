using System;
using System.Drawing;
using System.Windows.Forms;

namespace Test135
{
    public partial class Form_Interface : Form
    {
        /// <summary> Конструктор </summary>
        public Form_Interface() => InitializeComponent();

        private ITransport Selected_Transport;

        /// <summary> Обработка события. Загрузка формы </summary>
        private void Form_Interface_Load(object sender, EventArgs e)
        {
            Bitmap BiM = new Bitmap(PictureTransport.Width, PictureTransport.Height); PictureTransport.Image = BiM;
        }

        /// <summary> Обработка нажатия кнопок управления </summary>
        private void Interface_KeyDown(object sender, KeyEventArgs e)
        {
            bool T = false;

            // Обработка нажатия кнопки управления - 1 - Создание Car
            if (e.KeyCode == Keys.D1)
            {
                Random Rand = new Random(); T = true;
                Selected_Transport = new Car
                    (Transports.Car, Rand.Next(100, 300), Rand.Next(1000, 2000), Color.Blue);
                Selected_Transport.SetPosition
                    (new Point(Rand.Next(10, 100), Rand.Next(10, 100)), new Size(PictureTransport.Width, PictureTransport.Height));
            }

            // Обработка нажатия кнопки управления - 2 - Создание SportCar
            if (e.KeyCode == Keys.D2)
            {
                Random Rand = new Random(); T = true;
                Selected_Transport = new SportCar
                    (Transports.SportCar, Rand.Next(100, 300), Rand.Next(1000, 2000), Color.Red, Color.ForestGreen, Rand.Next(1, 4), Color.White);
                Selected_Transport.SetPosition
                    (new Point(Rand.Next(10, 100), Rand.Next(10, 100)), new Size(PictureTransport.Width, PictureTransport.Height));
            }

            // Обработка нажатия кнопки управления - 3 - Создание Cruiser
            if (e.KeyCode == Keys.D3)
            {
                Bitmap BM_Flag = new Bitmap(15, 9); Graphics Grap_Flag = Graphics.FromImage(BM_Flag);

                Grap_Flag.FillRectangle(new SolidBrush(Color.White), 0, 0, 15, 3);
                Grap_Flag.FillRectangle(new SolidBrush(Color.Blue), 0, 3, 15, 3);
                Grap_Flag.FillRectangle(new SolidBrush(Color.Red), 0, 6, 15, 3);
                Grap_Flag.FillRectangle(new SolidBrush(Color.Gold), 10, 3, 3, 3);

                Random Rand = new Random(); T = true;
                Selected_Transport = new Cruiser
                    (Transports.Cruiser, Rand.Next(300, 600), Rand.Next(1000, 2000), Color.Red, BM_Flag);
                Selected_Transport.SetPosition
                    (new Point(Rand.Next(10, 100), Rand.Next(10, 100)), new Size(PictureTransport.Width, PictureTransport.Height));
            }

            if (Selected_Transport != null)
            {
                // Вверх
                if (e.KeyCode == Keys.W | e.KeyCode == Keys.Up)
                {
                    Selected_Transport.MoveTransport(Directions.Up);
                    T = true;
                }

                // Вниз
                if (e.KeyCode == Keys.S | e.KeyCode == Keys.Down)
                {
                    Selected_Transport.MoveTransport(Directions.Down);
                    T = true;
                }

                // Влево
                if (e.KeyCode == Keys.A | e.KeyCode == Keys.Left)
                {
                    Selected_Transport.MoveTransport(Directions.Left);
                    T = true;
                }

                // Вправо
                if (e.KeyCode == Keys.D | e.KeyCode == Keys.Right)
                {
                    Selected_Transport.MoveTransport(Directions.Right);
                    T = true;
                }
            }

            if (T)
            {
                Bitmap BiM = new Bitmap(PictureTransport.Width, PictureTransport.Height); PictureTransport.Image = BiM;
               // Textures.Drawing(PictureTransport, Selected_Transport);
            }
        }
    }
}