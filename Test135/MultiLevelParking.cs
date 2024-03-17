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
        public Parking<ITransport> this[int Index]
        {
            get
            {
                if (Index > -1 & Index < ParkingStages.Count)
                    return ParkingStages[Index];
                else throw new Exceptions.Errors.UnacceptableParkingLevelNumber(Index);
            }
        }

        /// <summary> Сохранение информации по транспорту на парковках в файл </summary>
        /// <param name="FileName">Путь и имя файла</param>
        public void SaveData(string FileLine)
        {
            try
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

                Exception ex = new Exceptions.Information.SaveData();
                Form_Parking.LoG.Info($"{ex.Data["Say"]}. {ex.Message}");
                MessageBox.Show(ex.Message, ex.Data["Say"].ToString(), MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                Exception ex = new Exceptions.Errors.SaveData();
                Form_Parking.LoG.Info($"{ex.Data["Kod"]}. {ex.Message}");
                MessageBox.Show(ex.Message, ex.Data["Kod"].ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            try
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

                //MessageBox.Show(BufferTextFromFile); // Вывод читаемого файла

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
                    if (strs[i].Contains("Level")) { СounterLevel++; continue; }
                    if (string.IsNullOrEmpty(strs[i])) continue;
                    if (Transport != null & strs[i].Contains("End."))
                    {
                        ParkingStages[СounterLevel][NumberPlace] = Transport;
                        Transport = null; continue;
                    }

                    if (strs[i].Split(':').Length == 3)
                    {
                        var strsParameters = strs[i].Split(':')[2].Split('#');
                        NumberPlace = Convert.ToInt32(strs[i].Split(':')[0]) - 1;

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
                                    string BitmapPath = $@"{FileLine}\Bitmap PT\{СounterLevel + 1}_{NumberPlace + 1}_Cruiser.png";
                                    Bitmap BM_Flag = new Bitmap(15, 9);
                                    if (File.Exists(BitmapPath)) BM_Flag = (Bitmap)Image.FromFile(BitmapPath);

                                    Transport = new Cruiser(Transports.Cruiser, Convert.ToInt32(strsParameters[1]), Convert.ToInt32(strsParameters[2]), Color.Red, BM_Flag);
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
            catch
            {
                return false;
            }
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