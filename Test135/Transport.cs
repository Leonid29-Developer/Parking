using System.Drawing;
using System.Windows.Forms;

namespace Test135
{
    /// <summary> Класс отрисовки транспорт </summary>
    public class Transport
    {
        /// <summary> Координаты отрисовки </summary>
        private Point _startPos;
        /// <summary> Размеры окна отрисовки </summary>
        private Size _picture;
        /// <summary> Размер отрисовки</summary>
        private Size _size = new Size(110, 70);

        /// <summary> Максимальная скорость </summary>
        public int MaxSpeed { private set; get; }
        /// <summary> Вес </summary>
        public float Weight { private set; get; }

        /// <summary> Тип транспорта </summary>
        public Transports Type { private set; get; }
        /// <summary> Направление транспорта </summary>
        public Directions Direction { private set; get; }

        /// <summary> Основной цвет </summary>
        public Color MainColor { private set; get; }
        /// <summary> Дополнительный цвет </summary>
        public Color DopColor { private set; get; }

        /// <summary> Признаки наличия дополнительных элементов транспорта </summary> </summary>
        public AdditionalElements Elements { private set; get; }

        /// <summary> Конструктор </summary>
        /// <param name="maxSpeed">Максимальная скорость</param>
        /// <param name="weight">Вес автомобиля</param>
        /// <param name="mainColor">Основной цвет кузова</param>
        /// <param name="dopColor">Дополнительный цвет</param>
        /// <param name="frontSpoiler">Признак наличия переднего спойлера</param>
        /// <param name="sideSpoiler">Признак наличия боковых спойлеров</param>
        /// <param name="backSpoiler">Признак наличия заднего спойлера</param>
        public Transport(Transports type, Directions direction, int maxSpeed, float weight, Color mainColor, Color dopColor, AdditionalElements Element)
        {
            Type = type; Direction = direction;
            MaxSpeed = maxSpeed; Weight = weight;
            MainColor = mainColor; DopColor = dopColor;
            Elements = Element;
        }

        /// <summary> Установка позиции автомобиля </summary>
        /// <param name="XY">Координаты</param>
        /// <param name="Width_Height">Размер картинки</param>
        public void SetPosition(Point XY, Size Width_Height)
        { _startPos = XY; _picture = Width_Height; }

        /// <summary> Изменение направления пермещения </summary>
        /// <param name="Direction">Направление</param>
        public void MoveTransport(Directions NewDirection)
        {
            float step = MaxSpeed * 100 / Weight;
            switch (NewDirection)
            {
                // Вправо
                case Directions.Right:
                    {
                        if (_startPos.X + step < _picture.Width - _size.Width) _startPos = new Point((int)(_startPos.X + step), _startPos.Y);
                        Direction = Directions.Right;
                    }
                    break;

                // Влево
                case Directions.Left:
                    {
                        if (_startPos.X - step > 0) _startPos = new Point((int)(_startPos.X - step), _startPos.Y);
                        Direction = Directions.Left;
                    }
                    break;

                // Вверх
                case Directions.Up:
                    if (_startPos.Y - step > 0) _startPos = new Point(_startPos.X, (int)(_startPos.Y - step)); break;

                // Вниз
                case Directions.Down:
                    if (_startPos.Y + step < _picture.Height - _size.Height) _startPos = new Point(_startPos.X, (int)(_startPos.Y + step)); break;
            }
        }

        /// <summary> Метод отрисовки машины </summary>
        /// <param name="PictureTransport">Элемент управления - Интерфейс</param>
        public void Draw(PictureBox PictureTransport)
        {
            Bitmap BiM = new Bitmap(PictureTransport.Width, PictureTransport.Height); Graphics GR = Graphics.FromImage(BiM);
            Textures.Drawing(GR, Type, Direction, _startPos, _size, Elements, MainColor, DopColor); PictureTransport.Image = BiM;
        }
    }
}