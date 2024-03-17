using System.Drawing;

namespace Test135
{
    /// <summary> Класс отрисовки транспорта - Car </summary>
    public class Car : Vehicle
    {
        /// <summary> Конструктор </summary>
        /// <param name="type">Тип транспорта</param>
        /// <param name="maxSpeed">Максимальная скорость</param>
        /// <param name="weight">Вес автомобиля</param>
        /// <param name="NewMainColor">Основной цвет кузова</param>
        public Car(Transports type, int maxSpeed, float weight, Color NewMainColor)
        {
            Type = type; Direction = Directions.Right; MainColor = NewMainColor;
            MaxSpeed = maxSpeed; Weight = weight; _size = new Size(100, 60);
        }

        /// <summary> Получение размера автомобиля </summary>
        public override Size GetSize() => _size;

        /// <summary>Изменение цвета транспорта</summary>
        /// <param name="NewColor">Назначаемый цвет</param>
        /// /// <param name="TypeColor">Тип назначаемого цвета</param>
        public override void SetColor(Color NewColor, TypesСolors TypeColor) => MainColor = NewColor;

        /// <summary> Метод отрисовки машины </summary>
        /// <param name="Grap_Transport">Элемент управления - Интерфейс</param>
        public override void Draw(Graphics Grap_Transport)
        {
            Pen pen = new Pen(Color.Black);

            // Задние фары
            {
                Brush brRed = new SolidBrush(Color.Red);
                Grap_Transport.FillEllipse(brRed, 5, 5, 20, 20);
                Grap_Transport.FillEllipse(brRed, 5, 35, 20, 20);
            }

            // Передние фары
            {
                Brush brYellow = new SolidBrush(Color.Yellow);
                Grap_Transport.FillEllipse(brYellow, 75, 5, 20, 20);
                Grap_Transport.FillEllipse(brYellow, 75, 35, 20, 20);
            }

            // Границы автомобиля
            {
                Grap_Transport.DrawEllipse(pen, 5, 5, 20, 20);
                Grap_Transport.DrawEllipse(pen, 5, 35, 20, 20);
                Grap_Transport.DrawEllipse(pen, 75, 5, 20, 20);
                Grap_Transport.DrawEllipse(pen, 75, 35, 20, 20);
                Grap_Transport.DrawRectangle(pen, 5, 15, 10, 30);
                Grap_Transport.DrawRectangle(pen, 85, 15, 10, 30);
                Grap_Transport.DrawRectangle(pen, 15, 5, 70, 50);
            }

            // Кузов
            {
                Brush br = new SolidBrush(MainColor);
                Grap_Transport.FillRectangle(br, 5, 15, 10, 30);
                Grap_Transport.FillRectangle(br, 85, 15, 10, 30);
                Grap_Transport.FillRectangle(br, 15, 5, 70, 50);
            }

            // Стекла
            {
                Brush brBlue = new SolidBrush(Color.LightBlue);
                Grap_Transport.FillRectangle(brBlue, 65, 10, 5, 40);
                Grap_Transport.FillRectangle(brBlue, 25, 10, 5, 40);
                Grap_Transport.FillRectangle(brBlue, 30, 8, 35, 2);
                Grap_Transport.FillRectangle(brBlue, 30, 51, 35, 2);
            }

            // Рамка крыши
            {
                Grap_Transport.DrawRectangle(pen, 30, 10, 35, 40);
                Grap_Transport.DrawRectangle(pen, 70, 15, 25, 30);
                Grap_Transport.DrawRectangle(pen, 5, 15, 15, 30);
            }
        }

        /// <summary> Получение параметра Bitmap транспорта </summary>
        public override Bitmap FlagBM { get; set; }
    }
}