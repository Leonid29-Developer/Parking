using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Test135
{
    /// <summary> Параметризованны класс для хранения набора объектов от интерфейса ITransport </summary>
    public class Parking<T> where T : class, ITransport
    {
        /// <summary> Массив объектов </summary>
        private Dictionary<int, T> _places = new Dictionary<int, T>();

        /// <summary> Размер окна отрисовки </summary>
        private Size PictureSize { get; set; }

        private Point PlaceCount { get; set; }

        /// <summary> Размер парковочного места (ширина) </summary>
        private const int _placeSizeWidth = 220;

        /// <summary> Размер парковочного места (высота) </summary>
        private const int _placeSizeHeight = 120;

        /// <summary> Расстояние между парковочными местами </summary>
        private const int Distance = 100;

        /// <summary> Конструктор </summary>
        /// <param name="NewPictureSize">Рамзер парковки</param>
        public Parking(Size NewPictureSize) => Resize(NewPictureSize);

        /// <summary> Обновление размера парковки </summary>
        public void Resize(Size NewPictureSize)
        {
            int CountX = NewPictureSize.Width / (_placeSizeWidth + Distance);
            int CountY = NewPictureSize.Height / _placeSizeHeight;

            PictureSize = NewPictureSize; PlaceCount = new Point(CountX, CountY);
        }

        /// <summary> Перегрузка оператора степени <br/> 
        /// Логика действия: Изменение координат </summary>
        /// <param name="p">Парковка</param>
        public static int operator ^(Parking<T> p, int QR)
        {
            try
            {
                Point Offset = new Point(0, 0);
                for (int i = 0; i < p._places.Count; i++)
                    if (!p.CheckFreePlace(i))
                    {
                        switch (p._places[i].GetTypeTransport())
                        {
                            case Transports.Car: Offset = new Point(60, 30); break;
                            case Transports.SportCar: Offset = new Point(55, 25); break;
                            default: Offset = new Point(0, 0); break;
                        }

                        p._places[i].SetPosition
                                (new Point(i / p.PlaceCount.Y * (_placeSizeWidth + Distance) + Offset.X, i % p.PlaceCount.Y * _placeSizeHeight + Offset.Y),
                                new Size(p.PictureSize.Width, p.PictureSize.Height));
                    }
                return QR;
            }
            catch
            {
                throw new Exception();
            }
        }

        /// <summary> Перегрузка оператора сложения <br/> 
        /// Логика действия: на парковку добавляется автомобиль </summary>
        /// <param name="p">Парковка</param>
        /// <param name="car">Добавляемый автомобиль</param>
        public static int operator +(Parking<T> p, T Transport)
        {
            try
            {
                if (p._places.Count == p.PlaceCount.X * p.PlaceCount.Y)
                    throw new Exceptions.Errors.ParkingCrowded();

                for (int i = 0; i < p.PlaceCount.X * p.PlaceCount.Y; i++)
                    if (p.CheckFreePlace(i))
                    { p._places.Add(i, Transport); p.TransportParameters(p, i); return i; }

                return -1;
            }
            catch
            {
                throw new Exception();
            }
        }

        /// <summary> Назначение параметров согласно типу транспорта и его нахождению на парковке </summary>
        /// <param name="p">Парковка</param>
        /// <param name="i">Индекс объекта в парковке</param>
        private void TransportParameters(Parking<T> p, int i)
        {
            Point Offset = new Point(0, 0);

            switch (p._places[i].GetTypeTransport())
            {
                case Transports.Car: Offset = new Point(60, 30); break;
                case Transports.SportCar: Offset = new Point(55, 25); break;
            }

            p._places[i].SetPosition
                (new Point(i / p.PlaceCount.Y * (_placeSizeWidth + Distance) + Offset.X, i % p.PlaceCount.Y * _placeSizeHeight + Offset.Y),
                new Size(p.PictureSize.Width, p.PictureSize.Height));
        }

        /// <summary> Перегрузка оператора вычитания <br/> 
        /// Логика действия: с парковки забираем автомобиль </summary>
        /// <param name="p">Парковка</param>
        /// <param name="index">Индекс места, с которого пытаемся извлечь объект</ param>
        public static T operator -(Parking<T> p, int Index)
        {
            if (Index < 0 | Index > p.PlaceCount.X * p.PlaceCount.Y)
                throw new Exceptions.Errors.InvalidParkingSpaceNumber(Index);
            if (!p.CheckFreePlace(Index))
            {
                T Transport = p._places[Index];
                p._places.Remove(Index);
                return Transport;
            }
            else throw new Exceptions.Errors.NoParkingPlaceFound(Index);
        }

        /// <summary> Метод проверки заполнености парковочного места (ячейки массива) </summary>
        /// <param name="index">Номер парковочного места (порядковый номер в массиве)</param>
        private bool CheckFreePlace(int index)
        { return !_places.ContainsKey(index); }

        /// <summary> Метод отрисовки парковки </summary>
        public void Draw(Graphics g)
        {
            try
            {
                DrawMarking(g);
                if (_places != null)
                {
                    List<int> keys = _places.Keys.ToList();
                    for (int i = 0; i < keys.Count; i++)
                        Textures.Drawing(g, _places[keys[i]]);
                }
            }
            catch
            {
                throw new Exception();
            }
        }

        /// <summary> Метод отрисовки разметки парковочных мест  </summary>
        private void DrawMarking(Graphics g)
        {
            try
            {
                Pen pen = new Pen(Color.Black, 4);
                Pen PlanePen = new Pen(Color.Black, 2);

                g.DrawRectangle(pen, 0, 0, PictureSize.Width, PictureSize.Height);

                for (int i = 0; i < PlaceCount.X; i++)
                {
                    int StartPositionX = i * _placeSizeWidth + i * Distance;

                    g.DrawLine
                        (PlanePen, StartPositionX, 0, StartPositionX + _placeSizeWidth, 0);

                    for (int j = 0; j < PlaceCount.Y; ++j)
                    {
                        int StartPositionY = j * _placeSizeHeight;

                        g.DrawLine
                        (PlanePen, StartPositionX, StartPositionY, StartPositionX, StartPositionY + _placeSizeHeight);

                        g.DrawLine
                        (PlanePen, StartPositionX, _placeSizeHeight + StartPositionY, StartPositionX + _placeSizeWidth, _placeSizeHeight + StartPositionY);
                    }
                }
            }
            catch
            {
                throw new Exception();
            }
        }

        /// <summary> Индексатор </summary>
        public T this[int Index]
        {
            get
            {
                if (_places.ContainsKey(Index))
                    return _places[Index];
                else return null;

            }
            set
            {
                if (CheckFreePlace(Index))
                { _places.Add(Index, value); TransportParameters(this, Index); }
                else new Exceptions.Errors.ParkingSpaceOccupied(Index);
            }
        }

        ///<summary> Получение количества парковочных мест </summary>
        public int GetPlaceCount
        {
            get
            {
                return _places.Count;
            }
        }
    }
}