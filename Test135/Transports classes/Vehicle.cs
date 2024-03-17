using System.Drawing;

namespace Test135
{
    public abstract class Vehicle : ITransport
    {
        /// <summary> Координаты отрисовки </summary>
        protected Point _startPos;
        /// <summary> Размеры окна отрисовки </summary>
        protected Size _picture;
        /// <summary> Размер отрисовки</summary>
        protected Size _size;

        /// <summary> Максимальная скорость </summary>
        public int MaxSpeed { protected set; get; }
        /// <summary> Вес </summary>
        public float Weight { protected set; get; }

        /// <summary> Тип транспорта </summary>
        public Transports Type { protected set; get; }

        /// <summary> Направление транспорта </summary>
        public Directions Direction { protected set; get; }

        /// <summary> Основной цвет транспорта </summary>
        public Color MainColor { protected set; get; }

        /// <summary> Получение типа транспорта </summary>
        public Transports GetTypeTransport() => Type;

        /// <summary> Получение направления транспорта </summary>
        public Directions GetDirection() => Direction;

        /// <summary> Получение позиции транспорта </summary>
        public Point GetPosition() => _startPos;

        /// <summary> Получение размера автомобиля </summary>
        public abstract Size GetSize();

        /// <summary> Установка позиции транспорта </summary>
        /// <param name="XY">Координаты</param>
        /// <param name="Width_Height">Размер картинки</param>
        public void SetPosition(Point XY, Size Width_Height)
        { _startPos = XY; _picture = Width_Height; }

        /// <summary> Изменение направления пермещения </summary>
        /// <param name="Direction">Направление</param>
        public void MoveTransport(Directions NewDirection)
        {
            //float step = MaxSpeed * 100 / Weight;
            switch (NewDirection)
            {
                // Вправо
                case Directions.Right: Direction = Directions.Right; break;

                // Влево
                case Directions.Left: Direction = Directions.Left; break;

                    //// Вверх
                    //case Directions.Up:
                    //    if (_startPos.Y - step > 0) _startPos = new Point(_startPos.X, (int)(_startPos.Y - step)); break;

                    //// Вниз
                    //case Directions.Down:
                    //    if (_startPos.Y + step < _picture.Height - _size.Height) _startPos = new Point(_startPos.X, (int)(_startPos.Y + step)); break;
            }
        }

        /// <summary>Изменение цвета транспорта</summary>
        /// <param name="NewColor">Назначаемый цвет</param>
        /// /// <param name="TypeColor">Тип назначаемого цвета</param>
        public abstract void SetColor(Color NewColor, TypesСolors TypeColor);

        /// <summary> Получение параметра Bitmap транспорта </summary>
        public abstract Bitmap FlagBM { get; set; }

        /// <summary> Метод отрисовки траспорта </summary>
        /// <param name="Grap_Transport">Элемент управления - Интерфейс</param>
        public abstract void Draw(Graphics Grap_Transport);

        public override string ToString()
        {
            return $"{Type}: {Direction}#{MaxSpeed}#{Weight}" +
                $"\n      MainColor: [{MainColor.A}*{MainColor.R}*{MainColor.G}*{MainColor.B}]" +
                $"\n   End.";
        }
    }
}