using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test135
{
    public class Textures
    {
        public static void Drawing(/*PictureBox Pic_Background*/ Graphics Grap_Transport, Transport Selected_Transport, Point _startPos)
        {
            //Graphics Grap_Transport = Graphics.FromImage(Pic_Background.Image);

            switch (Selected_Transport.Type)
            {
                case Transports.SportCar:
                    {
                        Pen pen = new Pen(Color.Black);
                        // Отрисовка переднего спойлера автомобиля
                        if (Selected_Transport.FrontSpoiler)
                        {
                            Grap_Transport.DrawEllipse(pen, _startPos.X + 80, _startPos.Y - 6, 20, 20);
                            Grap_Transport.DrawEllipse(pen, _startPos.X + 80, _startPos.Y + 35, 20, 20);
                            Grap_Transport.DrawEllipse(pen, _startPos.X - 5, _startPos.Y - 6, 20, 20);
                            Grap_Transport.DrawEllipse(pen, _startPos.X - 5, _startPos.Y + 35, 20, 20);
                            Grap_Transport.DrawRectangle(pen, _startPos.X + 80, _startPos.Y - 6, 15, 15);
                            Grap_Transport.DrawRectangle(pen, _startPos.X + 80, _startPos.Y + 40, 15, 15);
                            Grap_Transport.DrawRectangle(pen, _startPos.X, _startPos.Y - 6, 14, 15);
                            Grap_Transport.DrawRectangle(pen, _startPos.X, _startPos.Y + 40, 14, 15);

                            Brush Spoiler = new SolidBrush(Selected_Transport.DopColor);
                            Grap_Transport.FillEllipse(Spoiler, _startPos.X + 80, _startPos.Y - 5, 20, 20);
                            Grap_Transport.FillEllipse(Spoiler, _startPos.X + 80, _startPos.Y + 35, 20, 20);
                            Grap_Transport.FillRectangle(Spoiler, _startPos.X + 75, _startPos.Y, 25, 40);
                            Grap_Transport.FillRectangle(Spoiler, _startPos.X + 80, _startPos.Y - 5, 15, 15);
                            Grap_Transport.FillRectangle(Spoiler, _startPos.X + 80, _startPos.Y + 40, 15, 15);
                            Grap_Transport.FillEllipse(Spoiler, _startPos.X - 5, _startPos.Y - 5, 20, 20);
                            Grap_Transport.FillEllipse(Spoiler, _startPos.X - 5, _startPos.Y + 35, 20, 20);
                            Grap_Transport.FillRectangle(Spoiler, _startPos.X - 5, _startPos.Y, 25, 40);
                            Grap_Transport.FillRectangle(Spoiler, _startPos.X, _startPos.Y - 5, 15, 15);
                            Grap_Transport.FillRectangle(Spoiler, _startPos.X, _startPos.Y + 40, 15, 15);
                        }
                        // Отрисовка бокового спойлера автомобиля
                        if (Selected_Transport.SideSpoiler)
                        {
                            Grap_Transport.DrawRectangle(pen, _startPos.X + 25, _startPos.Y - 6, 39, 10);
                            Grap_Transport.DrawRectangle(pen, _startPos.X + 25, _startPos.Y + 45, 39, 10);
                            Brush spoiler = new SolidBrush(Selected_Transport.DopColor);

                            Grap_Transport.FillRectangle(spoiler, _startPos.X + 25, _startPos.Y - 5, 40, 10);
                            Grap_Transport.FillRectangle(spoiler, _startPos.X + 25, _startPos.Y + 45, 40, 10);
                        }
                        // теперь отрисуем основной кузов автомобиля
                        //границы автомобиля
                        Grap_Transport.DrawEllipse(pen, _startPos.X, _startPos.Y, 20, 20);
                        Grap_Transport.DrawEllipse(pen, _startPos.X, _startPos.Y + 30, 20, 20);
                        Grap_Transport.DrawEllipse(pen, _startPos.X + 70, _startPos.Y, 20, 20);
                        Grap_Transport.DrawEllipse(pen, _startPos.X + 70, _startPos.Y + 30, 20, 20);
                        Grap_Transport.DrawRectangle(pen, _startPos.X - 1, _startPos.Y + 10, 10, 30);
                        Grap_Transport.DrawRectangle(pen, _startPos.X + 80, _startPos.Y + 10, 10, 30);
                        Grap_Transport.DrawRectangle(pen, _startPos.X + 10, _startPos.Y - 1, 70, 52);
                        //задние фары
                        Brush brRed = new SolidBrush(Color.Red);
                        Grap_Transport.FillEllipse(brRed, _startPos.X, _startPos.Y, 20, 20);
                        Grap_Transport.FillEllipse(brRed, _startPos.X, _startPos.Y + 30, 20, 20);
                        //передние фары
                        Brush brYellow = new SolidBrush(Color.Yellow);
                        Grap_Transport.FillEllipse(brYellow, _startPos.X + 70, _startPos.Y, 20, 20);
                        Grap_Transport.FillEllipse(brYellow, _startPos.X + 70, _startPos.Y + 30, 20, 20);
                        //кузов
                        Brush br = new SolidBrush(Selected_Transport.MainColor);
                        Grap_Transport.FillRectangle(br, _startPos.X, _startPos.Y + 10, 10, 30);
                        Grap_Transport.FillRectangle(br, _startPos.X + 80, _startPos.Y + 10, 10, 30);
                        Grap_Transport.FillRectangle(br, _startPos.X + 10, _startPos.Y, 70, 50);
                        //стекла
                        Brush brBlue = new SolidBrush(Color.LightBlue);
                        Grap_Transport.FillRectangle(brBlue, _startPos.X + 60, _startPos.Y + 5, 5, 40);
                        Grap_Transport.FillRectangle(brBlue, _startPos.X + 20, _startPos.Y + 5, 5, 40);
                        Grap_Transport.FillRectangle(brBlue, _startPos.X + 25, _startPos.Y + 3, 35, 2);
                        Grap_Transport.FillRectangle(brBlue, _startPos.X + 25, _startPos.Y + 46, 35, 2);
                        //выделяем рамкой крышу
                        Grap_Transport.DrawRectangle(pen, _startPos.X + 25, _startPos.Y + 5, 35, 40);
                        Grap_Transport.DrawRectangle(pen, _startPos.X + 65, _startPos.Y + 10, 25, 30);
                        Grap_Transport.DrawRectangle(pen, _startPos.X, _startPos.Y + 10, 15, 30);
                        // рисуем гоночные полоски
                        br = new SolidBrush(Selected_Transport.DopColor);
                        Grap_Transport.FillRectangle(br, _startPos.X + 65, _startPos.Y + 18, 25, 15);
                        Grap_Transport.FillRectangle(br, _startPos.X + 25, _startPos.Y + 18, 35, 15);
                        Grap_Transport.FillRectangle(br, _startPos.X, _startPos.Y + 18, 20, 15);
                        // рисуем задний спойлер автомобиля
                        if (Selected_Transport.BackSpoiler)
                        {
                            Brush spoiler = new SolidBrush(Selected_Transport.DopColor);
                            Grap_Transport.FillRectangle(spoiler, _startPos.X - 5, _startPos.Y, 10, 50);
                            Grap_Transport.DrawRectangle(pen, _startPos.X - 5, _startPos.Y, 10, 50);
                        }
                    }
                    break;
            }
        }
    }
}
