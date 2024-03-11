﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Test135;

namespace Test135
{
    /// <summary> Параметризованны класс для хранения набора объектов от интерфейса ITransport </summary>
    public class Parking<T> where T : class, ITransport
    {
        /// <summary> Массив объектов, которые храним </summary>
        private T[] _places;

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
        /// <param name="sizes">Количество мест на парковке</param>
        /// <param name="pictureWidth">Рамзер парковки - ширина</param>
        /// <param name="pictureHeight">Рамзер парковки - высота</param>
        public Parking(Size NewPictureSize)
        {
            int CountX = NewPictureSize.Width / (_placeSizeWidth + Distance);
            int CountY = NewPictureSize.Height / _placeSizeHeight;

PictureSize = NewPictureSize; PlaceCount = new Point(CountX, CountY);

            _places = new T[PlaceCount.X * PlaceCount.Y];
                for (int i = 0; i < _places.Length; i++) _places[i] = null;
        }

        public void Resize(Size NewPictureSize)
        {
            int CountX = NewPictureSize.Width / (_placeSizeWidth + Distance);
            int CountY = NewPictureSize.Height / _placeSizeHeight;

            PictureSize = NewPictureSize; PlaceCount = new Point(CountX, CountY);

            T[] Temp = new T[PlaceCount.X * PlaceCount.Y];
            for (int i = 0; i < Temp.Length; i++) Temp[i] = null;
            for (int i = 0; i < _places.Length & i < Temp.Length; i++)Temp[i] = _places[i];
                _places = Temp;
        }

        /// <summary> Перегрузка оператора степени <br/> 
        /// Логика действия: Изменение координат </summary>
        /// <param name="p">Парковка</param>
        public static int operator ^(Parking<T> p, int QR)
        {
            Point Offset = new Point(0, 0);
            for (int i = 0; i < p._places.Length; i++)
                if (!p.CheckFreePlace(i))
                {
                    switch (p._places[i].GetTypeTransport())
                    {
                        case Transports.Car: Offset = new Point(60, 30); break;
                        case Transports.SportCar: Offset = new Point(55, 25); break;
                        default: Offset = new Point(0,0); break;
                    }

                    p._places[i].SetPosition
                            (new Point(i / p.PlaceCount.Y * (_placeSizeWidth + Distance) + Offset.X, i % p.PlaceCount.Y * _placeSizeHeight + Offset.Y),
                            new Size(p.PictureSize.Width, p.PictureSize.Height));
                }
            return QR;
        }

        /// <summary> Перегрузка оператора сложения <br/> 
        /// Логика действия: на парковку добавляется автомобиль </summary>
        /// <param name="p">Парковка</param>
        /// <param name="car">Добавляемый автомобиль</param>
        public static int operator +(Parking<T> p, T Transport)
        {
            for (int i = 0; i < p._places.Length; i++)
                if (p.CheckFreePlace(i))
                {
                    p._places[i] = Transport; Point Offset = new Point(0, 0);

                    switch (p._places[i].GetTypeTransport())
                    {
                        case Transports.Car: Offset = new Point(60, 30); break;
                        case Transports.SportCar: Offset = new Point(55, 25); break;
                    }

                    Random Rand = new Random();
                    switch (Rand.Next(1, 3))
                    {
                        case 1: p._places[i].MoveTransport(Directions.Left); break;
                        case 2: p._places[i].MoveTransport(Directions.Right); break;
                    }

                    p._places[i].SetPosition
                        (new Point(i / p.PlaceCount.Y * (_placeSizeWidth + Distance) + Offset.X, i % p.PlaceCount.Y * _placeSizeHeight + Offset.Y),
                        new Size(p.PictureSize.Width, p.PictureSize.Height));
                    return i;
                }
            return -1;
        }

        /// <summary> Перегрузка оператора вычитания <br/> 
        /// Логика действия: с парковки забираем автомобиль </summary>
        /// <param name="p">Парковка</param>
        /// <param name="index">Индекс места, с которого пытаемся извлечь объект</ param>
        public static T operator -(Parking<T> p, int index)
        {
            if (index < 0 || index > p._places.Length) return null;
            if (!p.CheckFreePlace(index))
            {
                T car = p._places[index];
                p._places[index] = null;
                return car;
            }
            return null;
        }

        /// <summary> Метод проверки заполнености парковочного места (ячейки массива) </summary>
        /// <param name="index">Номер парковочного места (порядковый номер в массиве)</param>
        private bool CheckFreePlace(int index)
        { return _places[index] == null; }

        /// <summary> Метод отрисовки парковки </summary>
        public void Draw(Graphics g)
        {
            DrawMarking(g);
            for (int i = 0; i < _places.Length; i++)
                if (!CheckFreePlace(i))
               Textures.Drawing(g, _places[i]);
        }

        /// <summary> Метод отрисовки разметки парковочных мест  </summary>
        private void DrawMarking(Graphics g)
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
    }
}