using System.Drawing;

namespace Test135
{
    /// <summary> Класс отрисовки транспорта - Cruiser </summary>
    public class Cruiser : Vehicle
    {
        /// <summary> Дополнительный цвет траспорта </summary>
        public Color DopColor { private set; get; }

        /// <summary> Флаг траспорта </summary>
        public Bitmap Flag { private set; get; }

        /// <summary> Конструктор </summary>
        /// <param name="type">Тип транспорта</param>
        /// <param name="maxSpeed">Максимальная скорость траспорта</param>
        /// <param name="weight">Вес траспорта</param>
        /// <param name="NewMainColor">Основной цвет траспорта</param>
        /// <param name="NewDopColor">Дополнительный цвет</param>
        /// <param name="NewFlag"> Флаг траспорта</param>
        public Cruiser(Transports type, int maxSpeed, float weight, Color NewMainColor, Color NewDopColor, Bitmap NewFlag)
        {
            Type = type; Direction = Directions.Right;
            MainColor = NewMainColor; DopColor = NewDopColor; Flag = NewFlag;
            MaxSpeed = maxSpeed; Weight = weight; _size = new Size(212, 118);
        }

        /// <summary> Получение размера автомобиля </summary>
        public override Size GetSize() => _size;

        /// <summary> Метод отрисовки машины </summary>
        /// <param name="Grap_Transport">Элемент управления - Интерфейс</param>
        public override void Draw(Graphics Grap_Transport)
        {
            //Трубы
            for (int I1 = 0; I1 < 3; I1++)
            {
                Grap_Transport.FillRectangle(new SolidBrush(SystemColors.ControlDarkDark), 92 - 18 * I1, 42, 10, 50);
                Grap_Transport.DrawRectangle(new Pen(Color.Black), 92 - 18 * I1, 42, 10, 50);
            }

            //Флаштог + Провода
            Grap_Transport.FillRectangle(new SolidBrush(Color.White), 95, 15, 15, 3);
            Grap_Transport.FillRectangle(new SolidBrush(Color.Blue), 95, 18, 15, 3);
            Grap_Transport.FillRectangle(new SolidBrush(Color.Red), 95, 21, 15, 3);
            Grap_Transport.FillRectangle(new SolidBrush(Color.Gold), 97, 18, 3, 3);
            Grap_Transport.DrawRectangle(new Pen(Color.Black), 95, 15, 15, 9);

            Grap_Transport.DrawRectangle(new Pen(Color.DarkGray), 95, 30, 15, 1);
            Grap_Transport.DrawRectangle(new Pen(Color.DarkGray), 83, 31, 12, 1);
            Grap_Transport.DrawRectangle(new Pen(Color.DarkGray), 73, 32, 10, 1);
            Grap_Transport.DrawRectangle(new Pen(Color.DarkGray), 61, 31, 12, 1);
            Grap_Transport.DrawRectangle(new Pen(Color.DarkGray), 46, 30, 15, 1);

            Grap_Transport.DrawRectangle(new Pen(Color.Black), 110, 14, 1, 78);
            Grap_Transport.DrawRectangle(new Pen(Color.Black), 46, 28, 1, 64);

            //Башня 1 
            Grap_Transport.FillRectangle(new SolidBrush(SystemColors.ControlDarkDark), 183, 80, 22, 5);
            Grap_Transport.DrawRectangle(new Pen(Color.Black), 183, 80, 22, 5);
            Grap_Transport.FillEllipse(new SolidBrush(Color.DarkGray), 167, 78, 26, 26);
            Grap_Transport.DrawEllipse(new Pen(Color.Black), 167, 78, 26, 26);

            //Башня 2
            Grap_Transport.FillRectangle(new SolidBrush(SystemColors.ControlDarkDark), 7, 80, 22, 5);
            Grap_Transport.DrawRectangle(new Pen(Color.Black), 7, 80, 22, 5);
            Grap_Transport.FillEllipse(new SolidBrush(Color.DarkGray), 17, 78, 26, 26);
            Grap_Transport.DrawEllipse(new Pen(Color.Black), 17, 78, 26, 26);

            //ПВО
            Grap_Transport.FillEllipse(new SolidBrush(Color.DarkGray), 138, 79, 25, 25);
            Grap_Transport.DrawEllipse(new Pen(Color.Black), 138, 79, 25, 25);

            for (int I1 = 0; I1 < 9; I1++) Grap_Transport.DrawRectangle(new Pen(Color.Black), 152 + I1, 78 - I1, 1, 1);
            for (int I1 = 0; I1 < 8; I1++) Grap_Transport.DrawRectangle(new Pen(Color.Black), 153 + I1, 78 - I1, 1, 1);

            for (int I1 = 0; I1 < 8; I1++) Grap_Transport.DrawRectangle(new Pen(Color.Black), 156 + I1, 79 - I1, 1, 1);
            for (int I1 = 0; I1 < 8; I1++) Grap_Transport.DrawRectangle(new Pen(Color.Black), 156 + I1, 80 - I1, 1, 1);

            //Командный пункт
            Grap_Transport.FillRectangle(new SolidBrush(Color.DarkGray), 114, 72, 18, 20);
            Grap_Transport.DrawRectangle(new Pen(Color.Black), 114, 72, 18, 20);
            Grap_Transport.FillRectangle(new SolidBrush(Color.DarkGray), 114, 60, 21, 12);
            Grap_Transport.DrawRectangle(new Pen(Color.Black), 114, 60, 21, 12);
            Grap_Transport.FillRectangle(new SolidBrush(Color.LightBlue), 127, 62, 8, 7);
            Grap_Transport.DrawRectangle(new Pen(Color.Black), 127, 62, 8, 7);

            //Палуба
            Grap_Transport.FillRectangle(new SolidBrush(MainColor), 15, 106, 182, 4);
            Grap_Transport.DrawRectangle(new Pen(Color.Black), 15, 106, 182, 4);
            Grap_Transport.FillRectangle(new SolidBrush(MainColor), 10, 102, 192, 4);
            Grap_Transport.DrawRectangle(new Pen(Color.Black), 10, 102, 192, 4);
            Grap_Transport.FillRectangle(new SolidBrush(Color.Gray), 7, 94, 200, 8);
            Grap_Transport.DrawRectangle(new Pen(Color.Black), 7, 94, 200, 8);
            Grap_Transport.FillRectangle(new SolidBrush(Color.Black), 7, 92, 200, 2);
            Grap_Transport.DrawRectangle(new Pen(Color.Black), 7, 92, 200, 2);
        }
    }
}