using System.Drawing;

namespace Test135
{
    class Textures
    {
        /// <summary> Метод. Отрисовка транспорта </summary>
        /// <param name="PictureBackground"> Изображение для отрисовки </param>
        /// <param name="Selected_Transport"> Интерфейс транспорта </param>
        public static void Drawing(Graphics Grap, ITransport Selected_Transport)
        {
            Size Temp_Size = Selected_Transport.GetSize();

            Bitmap BiM = new Bitmap(Temp_Size.Width, Temp_Size.Height);
            Graphics Grap_T = Graphics.FromImage(BiM);

            Selected_Transport.Draw(Grap_T);

            //Grap_T.DrawRectangle(new Pen(Color.Black), 0, 0, Temp_Size.Width, Temp_Size.Height);

            switch (Selected_Transport.GetDirection())
            {
                case Directions.Left:
                    RF_BM(Grap, BiM, ModeFlip.FlipX, Selected_Transport.GetPosition());
                    break;

                case Directions.Right:
                    RF_BM(Grap, BiM, ModeFlip.None, Selected_Transport.GetPosition());
                    break;
            }

            //PictureBackground.Refresh();
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
                case ModeFlip.None:
                    for (int I1 = 0; I1 < Appended.Height; I1++) for (int I2 = 0; I2 < Appended.Width; I2++)
                        {
                            Brush Brush_Color = new SolidBrush(Appended.GetPixel(I2, I1));
                            Source.FillRectangle(Brush_Color, Position.X + I2, Position.Y + I1, 1, 1);
                        }
                    break;

                case ModeFlip.FlipX:
                    for (int I1 = 0; I1 < Appended.Height; I1++) for (int I2 = Appended.Width - 1, I3 = 0; I2 >= 0; I2--, I3++)
                        {
                            Brush Brush_Color = new SolidBrush(Appended.GetPixel(I2, I1));
                            Source.FillRectangle(Brush_Color, Position.X + I3, Position.Y + I1, 1, 1);
                        }
                    break;
            }
        }
    }
}