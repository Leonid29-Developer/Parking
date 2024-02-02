using System;
using System.Drawing;
using System.Windows.Forms;

namespace Test135
{
    public partial class Interface : Form
    {
        /// <summary> Конструктор </summary>
        public Interface() => InitializeComponent();

        private Transport Selected_Transport;

        /// <summary> Обработка нажатия кнопок управления </summary>
        private void Interface_KeyDown(object sender, KeyEventArgs e)
        {
            // Обработка нажатия кнопки управления - 1 - Создание SportCar
            if (e.KeyCode == Keys.D1)
            {
                Random Rand = new Random();
                Selected_Transport = new Transport(Transports.SportCar, Rand.Next(100, 300), Rand.Next(1000, 2000), Color.Blue, Color.Yellow, new AdditionalElements(true, true, true, false));
                Selected_Transport.SetPosition(new Point(Rand.Next(10, 100), Rand.Next(10, 100)), new Size(PictureTransport.Width, PictureTransport.Height));
            }

            // Обработка нажатия кнопки управления - 2 - Создание Cruiser
            if (e.KeyCode == Keys.D2)
            {
                Random Rand = new Random();
                Selected_Transport = new Transport(Transports.Cruiser, Rand.Next(100, 300), Rand.Next(1000, 2000), Color.Red, Color.Green, new AdditionalElements(false, false, false, false));
                Selected_Transport.SetPosition(new Point(Rand.Next(10, 100), Rand.Next(10, 100)), new Size(PictureTransport.Width, PictureTransport.Height));
            }

            if (Selected_Transport != null)
            {
                // Вверх
                if (e.KeyCode == Keys.W | e.KeyCode == Keys.Up) Selected_Transport.MoveTransport(Directions.Up);

                // Вниз
                if (e.KeyCode == Keys.S | e.KeyCode == Keys.Down) Selected_Transport.MoveTransport(Directions.Down);

                // Влево
                if (e.KeyCode == Keys.A | e.KeyCode == Keys.Left) Selected_Transport.MoveTransport(Directions.Left);

                // Вправо
                if (e.KeyCode == Keys.D | e.KeyCode == Keys.Right) Selected_Transport.MoveTransport(Directions.Right);

                Selected_Transport.Draw(PictureTransport);
            }
        }
    }
}