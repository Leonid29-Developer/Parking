using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test135
{
    public partial class Interface : Form
    {
        /// <summary> Конструктор </summary>
        public Interface() => InitializeComponent();

        private Transport Selected_Transport;

//private void Interface_Load(object sender, EventArgs e)
//        {
//            Bitmap BiM = new Bitmap(PictureTransport.Width, PictureTransport.Height); PictureTransport.Image = BiM;
//        }

        /// <summary> Обработка нажатия кнопок управления </summary>
        private void Interface_KeyDown(object sender, KeyEventArgs e)
        {
            // Обработка нажатия кнопки управления - Space
            if (e.KeyCode == Keys.Space | e.KeyCode == Keys.Enter)
            {
                Random Rand = new Random();
                Selected_Transport = new Transport (Transports.SportCar, Directions.Right, Rand.Next(100, 300), Rand.Next(1000, 2000), Color.Blue, Color.Yellow, true, true, true);
                Selected_Transport.SetPosition(new Point(Rand.Next(10, 100), Rand.Next(10, 100)), new Size(PictureTransport.Width, PictureTransport.Height));
            }

            // Вверх
            if (e.KeyCode == Keys.W | e.KeyCode == Keys.Up) Selected_Transport.MoveTransport(Directions.Up);

            // Вниз
            if (e.KeyCode == Keys.S | e.KeyCode == Keys.Down) Selected_Transport.MoveTransport(Directions.Down);

            // Влево
            if (e.KeyCode == Keys.A | e.KeyCode == Keys.Left) Selected_Transport.MoveTransport(Directions.Left);

            // Вправо
            if (e.KeyCode == Keys.D | e.KeyCode == Keys.Right) Selected_Transport.MoveTransport(Directions.Right);

            Draw();
        }

        /// <summary> Метод отрисовки машины </summary>
        private void Draw()
        {
            Bitmap BiM = new Bitmap(PictureTransport.Width, PictureTransport.Height); Graphics GR = Graphics.FromImage(BiM);
            Textures.Drawing(/*PictureTransport*/ GR, Selected_Transport, Selected_Transport._startPos); PictureTransport.Image = BiM;
        }
    }
}