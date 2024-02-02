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
            (Graphics Grap, Transports Type, Directions Direction, Point _startPos, Size _size, Color MainColor, Color DopColor, AdditionalElements Elements)
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