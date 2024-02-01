using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test135
{
    /// <summary> Класс отрисовки автомобиля </summary>
    public class Transport
    {
        /// <summary> Координаты отрисовки автомобиля </summary>
        public Point _startPos;
        /// <summary> Размеры окна отрисовки </summary>
        private Size _picture;
        /// <summary> Размер отрисовки автомобиля </summary>
        private Size CarSize = new Size(100,60);

        /// <summary> Максимальная скорость </summary>
        public int MaxSpeed { private set; get; }
        /// <summary> Вес автомобиля </summary>
        public float Weight { private set; get; }

        /// <summary> Тип транспорта  </summary>
        public Transports Type { private set; get; }
        /// <summary> Направление транспорта  </summary>
        public Directions Direction { private set; get; }

        /// <summary> Основной цвет кузова  </summary>
        public Color MainColor { private set; get; }
        /// <summary> Дополнительный цвет </summary>
        public Color DopColor { private set; get; }

        /// <summary> Признак наличия переднего спойлера </summary>
        public bool FrontSpoiler { private set; get; }
        /// <summary> Признак наличия боковых спойлеров </summary>
        public bool SideSpoiler { private set; get; }
        /// <summary> Признак наличия заднего спойлера </summary>
        public bool BackSpoiler { private set; get; }

        /// <summary> Конструктор </summary>
        /// <param name="maxSpeed">Максимальная скорость</param>
        /// <param name="weight">Вес автомобиля</param>
        /// <param name="mainColor">Основной цвет кузова</param>
        /// <param name="dopColor">Дополнительный цвет</param>
        /// <param name="frontSpoiler">Признак наличия переднего спойлера</param>
        /// <param name="sideSpoiler">Признак наличия боковых спойлеров</param>
        /// <param name="backSpoiler">Признак наличия заднего спойлера</param>
        public Transport(Transports type, Directions direction,int maxSpeed, float weight, Color mainColor, Color dopColor, bool frontSpoiler, bool sideSpoiler, bool backSpoiler)
        {
            Type = type;Direction = direction;
            MaxSpeed = maxSpeed; Weight = weight;
            MainColor = mainColor; DopColor = dopColor;
            FrontSpoiler = frontSpoiler; SideSpoiler = sideSpoiler; BackSpoiler = backSpoiler;
        }

        /// <summary> Установка позиции автомобиля </summary>
        /// <param name="XY">Координаты</param>
        /// <param name="Width_Height">Размер картинки</param>
        public void SetPosition(Point XY, Size Width_Height)
        { _startPos = XY; _picture = Width_Height; }

        /// <summary> Изменение направления пермещения </summary>
        /// <param name="Direction">Направление</param>
        public void MoveTransport(Directions Direction)
        {
            float step = MaxSpeed * 100 / Weight;
            switch (Direction)
            {
                // Вправо
                case Directions.Right: if (_startPos.X + step < _picture.Width - CarSize.Width) _startPos = new Point((int)(_startPos.X+step),_startPos.Y); break;

                // Влево
                case Directions.Left: if (_startPos.X - step > 0) _startPos = new Point((int)(_startPos.X - step), _startPos.Y); break;

                // Вверх
                case Directions.Up: if (_startPos.Y - step > 0) _startPos = new Point(_startPos.X, (int)(_startPos.Y - step)); break;

                // Вниз
                case Directions.Down: if (_startPos.Y + step < _picture.Height - CarSize.Height) _startPos = new Point(_startPos.X, (int)(_startPos.Y + step)); break;
            }
        }
    }
}