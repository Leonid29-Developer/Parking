using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Test135
{
    public class MultiLevelParking
    {
        /// <summary> Список с уровнями парковки </summary>
        List<Parking<ITransport>> ParkingStages;

        /// <summary> Текущий размер парковки </summary>
        private Size ParkingSize { get; set; }

        /// <summary> Конструктор </summary>
        /// <param name="СountStages">Количество уровенй парковки</param>
        public MultiLevelParking(int СountStages, Size PictureSize)
        {
            ParkingSize = PictureSize;
            ParkingStages = new List<Parking<ITransport>>();
            for (int i = 0; i < СountStages; ++i)
                ParkingStages.Add(new Parking<ITransport>(new Size(PictureSize.Width, PictureSize.Height)));
        }

        /// <summary> Индексатор </summary>
        public Parking<ITransport> this[int ind]
        {
            get
            {
                if (ind > -1 && ind < ParkingStages.Count)
                    return ParkingStages[ind];
                return null;
            }
        }

        /// <summary> Сохранение информации по транспорту на парковках в файл </summary>
        /// <param name="FileName">Путь и имя файла</param>
        public bool SaveData(string FileLine)
        {
            if (File.Exists($@"{FileLine}\PTP.txt"))
            {
                File.Delete($@"{FileLine}\PTP.txt");
                Directory.Delete($@"{FileLine}\Bitmap PT\", true);
            }
            using (FileStream FS = new FileStream($@"{FileLine}\PTP.txt", FileMode.Create))
            {
                //Записываем количество уровней
                WriteToFile($"CountLeveles: {ParkingStages.Count}" + Environment.NewLine, FS);

                int LevelNumber = 1;
                foreach (var Level in ParkingStages)
                {
                    WriteToFile(Environment.NewLine + $"Level: {LevelNumber}" + Environment.NewLine, FS);
                    for (int i = 0; i < Level.GetPlaceCount; i++)
                    {
                        ITransport Transport = Level[i];
                        if (Transport != null)
                        {
                            WriteToFile($"{i + 1}: {Transport}" + Environment.NewLine, FS);
                            if (Transport.GetTypeTransport() == Transports.Cruiser)
                            {
                                Bitmap BM = Transport.FlagBM;
                                Directory.CreateDirectory($@"{FileLine}\Bitmap PT\");
                                BM.Save($@"{FileLine}\Bitmap PT\{LevelNumber}_{i + 1}_{Transport.GetTypeTransport()}.png", ImageFormat.Png);
                            }
                        }
                    }
                    LevelNumber++;
                }
            }
            return true;
        }

        /// <summary> Метод записи информации в файл </summary>
        /// <param name="Text">Строка, которую следует записать</param>
        /// <param name="stream">Поток для записи</param>
        private void WriteToFile(string Text, FileStream stream)
        {
            byte[] info = new UTF8Encoding(true).GetBytes(Text);
            stream.Write(info, 0, info.Length);
        }

        /// <summary>  Загрузка нформации по транспорту  на парковках из файла </summary>
        /// <param name="FileLine">Путь и имя файла</param>
        public bool LoadData(string FileLine)
        {
            if (!File.Exists($@"{FileLine}\PTP.txt")) return false;

            string BufferTextFromFile = "";
            using (FileStream fs = new FileStream($@"{FileLine}\PTP.txt", FileMode.Open))
            {
                byte[] b = new byte[fs.Length];
                UTF8Encoding temp = new UTF8Encoding(true);
                while (fs.Read(b, 0, b.Length) > 0)
                    BufferTextFromFile += temp.GetString(b);
            }

            BufferTextFromFile = BufferTextFromFile.Replace("\r", "");
            BufferTextFromFile = BufferTextFromFile.Replace(" ", "");

            MessageBox.Show(BufferTextFromFile);

            var strs = BufferTextFromFile.Split('\n');
            if (strs[0].Contains("CountLeveles"))
            {
                // Количество уровней
                int СountStages = Convert.ToInt32(strs[0].Split(':')[1]);

                if (ParkingStages != null) ParkingStages.Clear();

                ParkingStages = new List<Parking<ITransport>>();
                for (int i = 0; i < СountStages; ++i)
                    ParkingStages.Add(new Parking<ITransport>(new Size(ParkingSize.Width, ParkingSize.Height)));
            }
            else return false;

            int СounterLevel = -1, NumberPlace = -1;
            ITransport Transport = null;
            for (int i = 1; i < strs.Length; ++i)
            {
                //MessageBox.Show($"{strs[i]}\n{СounterLevel} / {NumberPlace}");

                if (strs[i].Contains("Level")) { СounterLevel++; continue; }
                if (string.IsNullOrEmpty(strs[i])) continue;
                if (Transport != null & strs[i].Contains("End."))
                {
                    ParkingStages[СounterLevel][NumberPlace] = Transport;
                    MessageBox.Show($"{СounterLevel} / {NumberPlace}\n{Transport.GetTypeTransport()}");
                    Transport = null; continue;
                }

                if (strs[i].Split(':').Length == 3)
                {
                    var strsParameters = strs[i].Split(':')[2].Split('#');
                    NumberPlace = Convert.ToInt32(strs[i].Split(':')[0]) - 1;

                    //MessageBox.Show($"strs[i].Split(':')[2]\n{strs[i].Split(':')[2]}");

                    // MessageBox.Show(ParkingStages[СounterLevel][NumberPlace].ToString());

                    switch (strs[i].Split(':')[1])
                    {
                        case "Car":
                            Transport = new Car
                                (Transports.Car, Convert.ToInt32(strsParameters[1]), Convert.ToInt32(strsParameters[2]), Color.Red);
                            break;

                        case "SportCar":
                            Transport = new SportCar
                                (Transports.SportCar, Convert.ToInt32(strsParameters[1]), Convert.ToInt32(strsParameters[2]), Color.Red,
                                Color.Black, Convert.ToInt32(strsParameters[3]), Color.White);
                            break;

                        case "Cruiser":
                            {
                                Bitmap BM_Flag = new Bitmap(15, 9); Graphics Grap_Flag = Graphics.FromImage(BM_Flag);

                                Grap_Flag.FillRectangle(new SolidBrush(Color.White), 0, 0, 15, 3);
                                Grap_Flag.FillRectangle(new SolidBrush(Color.Blue), 0, 3, 15, 3);
                                Grap_Flag.FillRectangle(new SolidBrush(Color.Red), 0, 6, 15, 3);
                                Grap_Flag.FillRectangle(new SolidBrush(Color.Gold), 10, 3, 3, 3);

                                Transport = new Cruiser(Transports.Cruiser, Convert.ToInt32(strsParameters[1]), (float)Convert.ToDouble(strsParameters[2]), Color.Red, BM_Flag);
                            }
                            break;
                    }

                    switch (strsParameters[0])
                    {
                        case "Left": Transport.MoveTransport(Directions.Left); break;
                        case "Right": Transport.MoveTransport(Directions.Right); break;
                    }
                }
                else
                {
                    if (Transport == null) break;

                    string BufferText = strs[i].Split(':')[1].Replace("[", "");
                    BufferText = BufferText.Replace("]", "");
                    var strsParameters = BufferText.Split('*');
                    SetColor(Transport, strs[i].Split(':')[0], strsParameters);
                }
            }

            return true;
        }

        /// <summary>  Назначение транспорту по типу цвета из ARGB </summary>
        /// <param name="Transport">Транспорт</param>
        /// <param name="TypeColor">Тип параметра цвета транспорта</param>
        private void SetColor(ITransport Transport, string TypeColor, string[] ARGB)
        {
            Color NewColor = Color.FromArgb(Convert.ToInt32(ARGB[0]), Convert.ToInt32(ARGB[1]), Convert.ToInt32(ARGB[2]), Convert.ToInt32(ARGB[3]));

            switch (TypeColor)
            {
                case "MainColor": Transport.SetColor(NewColor, TypesСolors.MainColor); break;
                case "DopColor": Transport.SetColor(NewColor, TypesСolors.DopColor); break;
                case "LineColor": Transport.SetColor(NewColor, TypesСolors.LineColor); break;
            }
        }
    }
}