using System.Drawing;

namespace Test135
{
    class Textures
    {
        /// <summary> Метод. Отрисовка транспорта по представленным данным  </summary>
        /// <param name="Grap"> Изображение для отрисовки </param>
        /// <param name="Type"> Тип транспорта </param>
        /// <param name="Direction"> Направление транспорта </param>
        /// <param name="_startPos"> Координаты отрисовки </param>
        /// <param name="_size"> Размер отрисовки </param>
        /// <param name="MainColor"> Основной цвет </param>
        /// <param name="DopColor"> Дополнительный цвет </param>
        /// <param name="Elements"> Признаки наличия дополнительных элементов транспорта </param>
        public static void Drawing
            (Graphics Grap, Transports Type, Directions Direction, Point _startPos, Size _size, Color MainColor, Color DopColor, AdditionalElements Elements, Bitmap Flag)
        {
            Bitmap BiM = new Bitmap(_size.Width, _size.Height); Graphics Grap_Transport = Graphics.FromImage(BiM);

            switch (Type)
            {
                case Transports.SportCar:
                    {
                        // Текстура
                        {
                            Pen pen = new Pen(Color.Black);
                            // Отрисовка переднего спойлера автомобиля
                            if (Elements.Slot_1)
                            {
                                Grap_Transport.DrawEllipse(pen, 90, 4, 20, 20);
                                Grap_Transport.DrawEllipse(pen, 90, 45, 20, 20);
                                Grap_Transport.DrawEllipse(pen, 5, 4, 20, 20);
                                Grap_Transport.DrawEllipse(pen, 5, 45, 20, 20);
                                Grap_Transport.DrawRectangle(pen, 90, 4, 15, 15);
                                Grap_Transport.DrawRectangle(pen, 90, 50, 15, 15);
                                Grap_Transport.DrawRectangle(pen, 10, 4, 14, 15);
                                Grap_Transport.DrawRectangle(pen, 10, 50, 14, 15);

                                Brush Spoiler = new SolidBrush(DopColor);
                                Grap_Transport.FillEllipse(Spoiler, 90, 5, 20, 20);
                                Grap_Transport.FillEllipse(Spoiler, 90, 45, 20, 20);
                                Grap_Transport.FillRectangle(Spoiler, 85, 10, 25, 40);
                                Grap_Transport.FillRectangle(Spoiler, 90, 5, 15, 15);
                                Grap_Transport.FillRectangle(Spoiler, 90, 50, 15, 15);
                                Grap_Transport.FillEllipse(Spoiler, 5, 5, 20, 20);
                                Grap_Transport.FillEllipse(Spoiler, 5, 45, 20, 20);
                                Grap_Transport.FillRectangle(Spoiler, 5, 10, 25, 40);
                                Grap_Transport.FillRectangle(Spoiler, 10, 5, 15, 15);
                                Grap_Transport.FillRectangle(Spoiler, 10, 50, 15, 15);
                            }

                            // Отрисовка бокового спойлера автомобиля
                            if (Elements.Slot_2)
                            {
                                Grap_Transport.DrawRectangle(pen, 35, 4, 39, 10);
                                Grap_Transport.DrawRectangle(pen, 35, 55, 39, 10);
                                Brush spoiler = new SolidBrush(DopColor);

                                Grap_Transport.FillRectangle(spoiler, 35, 5, 40, 10);
                                Grap_Transport.FillRectangle(spoiler, 35, 55, 40, 10);
                            }

                            // Границы автомобиля
                            {
                                Grap_Transport.DrawEllipse(pen, 10, 10, 20, 20);
                                Grap_Transport.DrawEllipse(pen, 10, 40, 20, 20);
                                Grap_Transport.DrawEllipse(pen, 80, 10, 20, 20);
                                Grap_Transport.DrawEllipse(pen, 80, 40, 20, 20);
                                Grap_Transport.DrawRectangle(pen, 9, 20, 10, 30);
                                Grap_Transport.DrawRectangle(pen, 90, 20, 10, 30);
                                Grap_Transport.DrawRectangle(pen, 20, 9, 70, 52);
                            }

                            // Задние фары
                            {
                                Brush brRed = new SolidBrush(Color.Red);
                                Grap_Transport.FillEllipse(brRed, 10, 10, 20, 20);
                                Grap_Transport.FillEllipse(brRed, 10, 40, 20, 20);
                            }

                            // Передние фары
                            {
                                Brush brYellow = new SolidBrush(Color.Yellow);
                                Grap_Transport.FillEllipse(brYellow, 80, 10, 20, 20);
                                Grap_Transport.FillEllipse(brYellow, 90, 40, 20, 20);
                            }

                            // Кузов
                            {
                                Brush br = new SolidBrush(MainColor);
                                Grap_Transport.FillRectangle(br, 10, 20, 10, 30);
                                Grap_Transport.FillRectangle(br, 90, 20, 10, 30);
                                Grap_Transport.FillRectangle(br, 20, 10, 70, 50);
                            }

                            // Стекла
                            {
                                Brush brBlue = new SolidBrush(Color.LightBlue);
                                Grap_Transport.FillRectangle(brBlue, 70, 15, 5, 40);
                                Grap_Transport.FillRectangle(brBlue, 30, 15, 5, 40);
                                Grap_Transport.FillRectangle(brBlue, 35, 13, 35, 2);
                                Grap_Transport.FillRectangle(brBlue, 35, 56, 35, 2);
                            }

                            // Рамка крыши
                            {
                                Grap_Transport.DrawRectangle(pen, 35, 15, 35, 40);
                                Grap_Transport.DrawRectangle(pen, 75, 20, 25, 30);
                                Grap_Transport.DrawRectangle(pen, 10, 20, 15, 30);
                            }

                            // Рисуем гоночные полоски
                            {
                                SolidBrush br = new SolidBrush(DopColor);
                                Grap_Transport.FillRectangle(br, 75, 28, 25, 15);
                                Grap_Transport.FillRectangle(br, 35, 28, 35, 15);
                                Grap_Transport.FillRectangle(br, 10, 28, 20, 15);
                            }

                            // Рисуем задний спойлер автомобиля
                            if (Elements.Slot_3)
                            {
                                Brush spoiler = new SolidBrush(DopColor);
                                Grap_Transport.FillRectangle(spoiler, 5, 10, 10, 50);
                                Grap_Transport.DrawRectangle(pen, 5, 10, 10, 50);
                            }
                        }

                        // Вывод на экран
                        switch (Direction)
                        {
                            case Directions.Left: RF_BM(Grap, BiM, ModeFlip.FlipX, _startPos); break;

                            case Directions.Right: RF_BM(Grap, BiM, ModeFlip.None, _startPos); break;
                        }
                    }
                    break;

                case Transports.Cruiser:
                    {
                        // Текстура
                        {
                            //Трубы
                            for (int I1 = 0; I1 < 3; I1++) { Grap_Transport.FillRectangle(new SolidBrush(SystemColors.ControlDarkDark), 105 + 18 * I1, 72, 10, 50); Grap_Transport.DrawRectangle(new Pen(Color.Black), 105 + 18 * I1, +72, 10, 50); }

                            //Флаштог + Провода
                            Bitmap H = Flag; RF_BM(Grap_Transport, H, ModeFlip.None, new Point(97, 45)); Grap_Transport.DrawRectangle(new Pen(Color.Black), 97, 45, 15, 9);

                            Grap_Transport.DrawRectangle(new Pen(Color.DarkGray), 97, 60, 15, 1); Grap_Transport.DrawRectangle(new Pen(Color.DarkGray), 112, 61, 12, 1);
                            Grap_Transport.DrawRectangle(new Pen(Color.DarkGray), 124, 62, 10, 1); Grap_Transport.DrawRectangle(new Pen(Color.DarkGray), 134, 61, 12, 1);
                            Grap_Transport.DrawRectangle(new Pen(Color.DarkGray), 146, 60, 15, 1);

                            Grap_Transport.DrawRectangle(new Pen(Color.Black), 96, 44, 1, 78); Grap_Transport.DrawRectangle(new Pen(Color.Black), 160, 58, 1, 64);

                            //Башня 1 
                            Grap_Transport.FillRectangle(new SolidBrush(SystemColors.ControlDarkDark), +2, 110, 22, 5); Grap_Transport.DrawRectangle(new Pen(Color.Black), 2, 110, 22, 5);
                            Grap_Transport.FillEllipse(new SolidBrush(Color.DarkGray), 12, 108, 26, 26); Grap_Transport.DrawEllipse(new Pen(Color.Black), 12, 108, 26, 26);

                            //Башня 2
                            Grap_Transport.FillRectangle(new SolidBrush(SystemColors.ControlDarkDark), 178, 110, 22, 5); Grap_Transport.DrawRectangle(new Pen(Color.Black), 178, 110, 22, 5);
                            Grap_Transport.FillEllipse(new SolidBrush(Color.DarkGray), 164, 108, 26, 26); Grap_Transport.DrawEllipse(new Pen(Color.Black), 164, 108, 26, 26);

                            //ПВО
                            Grap_Transport.FillEllipse(new SolidBrush(Color.DarkGray), 44, 109, 25, 25); Grap_Transport.DrawEllipse(new Pen(Color.Black), 44, 109, 25, 25);

                            for (int I1 = 0; I1 < 9; I1++) Grap_Transport.DrawRectangle(new Pen(Color.Black), 54 - I1, 108 - I1, 1, 1);
                            for (int I1 = 0; I1 < 8; I1++) Grap_Transport.DrawRectangle(new Pen(Color.Black), 53 - I1, 108 - I1, 1, 1);

                            for (int I1 = 0; I1 < 8; I1++) Grap_Transport.DrawRectangle(new Pen(Color.Black), 50 - I1, 109 - I1, 1, 1);
                            for (int I1 = 0; I1 < 8; I1++) Grap_Transport.DrawRectangle(new Pen(Color.Black), 50 - I1, 110 - I1, 1, 1);

                            //Командный пункт
                            Grap_Transport.FillRectangle(new SolidBrush(Color.DarkGray), 75, 102, 18, 20); Grap_Transport.DrawRectangle(new Pen(Color.Black), 75, 102, 18, 20);
                            Grap_Transport.FillRectangle(new SolidBrush(Color.DarkGray), 72, 90, 21, 12); Grap_Transport.DrawRectangle(new Pen(Color.Black), 72, 90, 21, 12);
                            Grap_Transport.FillRectangle(new SolidBrush(Color.LightBlue), 72, 92, 8, 7); Grap_Transport.DrawRectangle(new Pen(Color.Black), 72, 92, 8, 7);

                            //Палуба
                            Grap_Transport.FillRectangle(new SolidBrush(MainColor), 10, 136, 182, 4); Grap_Transport.DrawRectangle(new Pen(Color.Black), 10, 136, 182, 4);
                            Grap_Transport.FillRectangle(new SolidBrush(MainColor), 5, 132, 192, 4); Grap_Transport.DrawRectangle(new Pen(Color.Black), 5, 132, 192, 4);
                            Grap_Transport.FillRectangle(new SolidBrush(Color.Gray), 0, 124, 200, 8); Grap_Transport.DrawRectangle(new Pen(Color.Black), 0, 124, 200, 8);
                            Grap_Transport.FillRectangle(new SolidBrush(Color.Black), 0, 122, 200, 2); Grap_Transport.DrawRectangle(new Pen(Color.Black), 0, 122, 200, 2);
                        }

                        // Вывод на экран
                        switch (Direction)
                        {
                            case Directions.Left: RF_BM(Grap, BiM, ModeFlip.None, _startPos); break;

                            case Directions.Right: RF_BM(Grap, BiM, ModeFlip.FlipX, _startPos); break;
                        }
                    }
                    break;
            }
        }

        /// <summary> Метод. Отзеркаливание или переворот изображения и наложение его на интерфейс </summary>
        /// <param name="Source"> Изображение на которое происходит отрисовка </param>
        /// <param name="Appended"> Отрисовываемое изображение </param>
        /// <param name="Flip"> Режим отрисовки </param>
        /// <param name="Position"> Координаты старта отрисовки на исходном изображении </param>
        private static void RF_BM(Graphics Source, Bitmap Appended, ModeFlip Flip, Point Position)
        {
            switch (Flip)
            {
                case ModeFlip.None: for (int I1 = 0; I1 < Appended.Height; I1++) for (int I2 = 0; I2 < Appended.Width; I2++) { Brush Brush_Color = new SolidBrush(Appended.GetPixel(I2, I1)); Source.FillRectangle(Brush_Color, Position.X + I2, Position.Y + I1, 1, 1); } break;

                case ModeFlip.FlipX: for (int I1 = 0; I1 < Appended.Height; I1++) for (int I2 = Appended.Width - 1; I2 >= 0; I2--) { Brush Brush_Color = new SolidBrush(Appended.GetPixel(I2, I1)); Source.FillRectangle(Brush_Color, Position.X + (Appended.Width - 1 - I2), Position.Y + I1, 1, 1); } break;
            }
        }
    }
}