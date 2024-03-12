using System.Drawing;

namespace Test135
{
    public class SportCar : Car
    {
        /// <summary> Количество полос </summary>
        private int _countLines;

        /// <summary> Дополнительный цвет траспорта </summary>
        public Color DopColor { private set; get; }

        /// <summary> Цвет полос транспорта </summary>
        public Color LineColor { private set; get; }

        /// <summary> Конструктор </summary>
        /// <param name="type">Тип транспорта</param>
        /// <param name="maxSpeed">Максимальная скорость</param>
        /// <param name="weight">Вес автомобиля</param>
        /// <param name="NewMainColor">Основной цвет кузова</param>
        /// <param name="NewDopColor">Дополнительный цвет</param>
        /// <param name="CountLine">Количество полос</param>
        /// <param name="NewLineColor">Цвет полос транспорта</param>
        public SportCar(Transports type, int maxSpeed, float weight, Color NewMainColor, Color NewDopColor, int CountLine, Color NewLineColor)
            : base(type, maxSpeed, weight, NewMainColor)
        { DopColor = NewDopColor; _size = new Size(110, 70); _countLines = CountLine; LineColor = NewLineColor; }

        /// <summary>Изменение цвета транспорта</summary>
        /// <param name="NewColor">Назначаемый цвет</param>
        /// <param name="TypeColor">Тип назначаемого цвета</param>
        public override void SetColor(Color NewColor, TypesСolors TypeColor)
        {
            switch (TypeColor)
            {
                case TypesСolors.MainColor: MainColor = NewColor; break;
                case TypesСolors.DopColor: DopColor = NewColor; break;
                case TypesСolors.LineColor: LineColor = NewColor; break;
            }
        }

        /// <summary> Метод отрисовки машины </summary>
        /// <param name="Grap_Transport">Элемент управления - Интерфейс</param>
        public override void Draw(Graphics Grap_Transport)
        {
            // Отрисовка переднего спойлера траспорта
            Pen pen = new Pen(Color.Black);
            {
                Grap_Transport.DrawEllipse(pen, 82, 0, 20, 20);
                Grap_Transport.DrawEllipse(pen, 82, 41, 20, 20);
                Grap_Transport.DrawRectangle(pen, 82, 0, 15, 15);
                Grap_Transport.DrawRectangle(pen, 82, 46, 15, 15);
                Grap_Transport.DrawRectangle(pen, 88, 8, 14, 46);

                Brush Spoiler = new SolidBrush(DopColor);
                Grap_Transport.FillEllipse(Spoiler, 82, 0, 20, 20);
                Grap_Transport.FillEllipse(Spoiler, 82, 41, 20, 20);
                Grap_Transport.FillRectangle(Spoiler, 82, 0, 15, 15);
                Grap_Transport.FillRectangle(Spoiler, 82, 46, 15, 15);
                Grap_Transport.FillRectangle(Spoiler, 88, 8, 14, 46);
            }

            // Отрисовка бокового спойлера траспорта
            {
                Grap_Transport.DrawRectangle(pen, 25, 2, 50, 8);
                Grap_Transport.DrawRectangle(pen, 28, 0, 44, 10);
                Grap_Transport.DrawRectangle(pen, 28, 51, 44, 10);
                Grap_Transport.DrawRectangle(pen, 25, 51, 50, 8);

                Brush spoiler = new SolidBrush(DopColor);
                Grap_Transport.FillRectangle(spoiler, 25, 2, 50, 8);
                Grap_Transport.FillRectangle(spoiler, 28, 1, 44, 9);
                Grap_Transport.FillRectangle(spoiler, 28, 52, 44, 9);
                Grap_Transport.FillRectangle(spoiler, 25, 52, 50, 8);
            }

            base.Draw(Grap_Transport);

            // Гоночные полосы на транспорте
            {
                Brush LC = new SolidBrush(LineColor);

                switch (_countLines)
                {
                    case 1:
                        {
                            Grap_Transport.FillRectangle(LC, 70, 23, 25, 15);
                            Grap_Transport.FillRectangle(LC, 30, 23, 35, 15);
                            Grap_Transport.FillRectangle(LC, 5, 23, 20, 15);
                        }
                        break;

                    case 2:
                        {
                            Grap_Transport.FillRectangle(LC, 70, 20, 25, 8);
                            Grap_Transport.FillRectangle(LC, 70, 33, 25, 8);
                            Grap_Transport.FillRectangle(LC, 30, 20, 35, 8);
                            Grap_Transport.FillRectangle(LC, 30, 33, 35, 8);
                            Grap_Transport.FillRectangle(LC, 5, 20, 20, 8);
                            Grap_Transport.FillRectangle(LC, 5, 33, 20, 8);
                        }
                        break;

                    case 3:
                        {
                            Grap_Transport.FillRectangle(LC, 70, 20, 25, 5);
                            Grap_Transport.FillRectangle(LC, 70, 28, 25, 5);
                            Grap_Transport.FillRectangle(LC, 70, 36, 25, 5);
                            Grap_Transport.FillRectangle(LC, 30, 20, 35, 5);
                            Grap_Transport.FillRectangle(LC, 30, 28, 35, 5);
                            Grap_Transport.FillRectangle(LC, 30, 36, 35, 5);
                            Grap_Transport.FillRectangle(LC, 5, 20, 20, 5);
                            Grap_Transport.FillRectangle(LC, 5, 28, 20, 5);
                            Grap_Transport.FillRectangle(LC, 5, 36, 20, 5);
                        }
                        break;
                }
            }

            // Отрисовка заднего спойлера транспорта
            {
                Brush spoiler = new SolidBrush(DopColor);
                Grap_Transport.FillRectangle(spoiler, 5, 3, 10, 54);
                Grap_Transport.DrawRectangle(pen, 5, 3, 10, 54);
            }
        }
    }
}