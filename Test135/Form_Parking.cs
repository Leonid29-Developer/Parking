using NLog;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Test135
{
    public partial class Form_Parking : Form
    {
        /// <summary> Объект от класса многоуровневой парковки </summary>
        MultiLevelParking parking;

        /// <summary> Количество уровней-парковок </summary>
        private const int countLevel = 6;

        /// <summary> Логгер </summary>
        public static Logger LoG;

        public Form_Parking()
        {
            LoG = LogManager.GetCurrentClassLogger();
            InitializeComponent(); NewDraw();
        }

        ///<summary> Обработка изменения размера формы </summary>
        private void FormParking_Resize(object sender, EventArgs e)
        {
            try
            {
                if (Width > 160 & Height > 30)
                {
                    for (int i = 0; i < countLevel; i++)
                    {
                        parking[i].Resize(new Size(pictureBoxParking.Width, pictureBoxParking.Height));
                        _ = parking[i] ^ 1;
                    }
                    Draw();

                    LoG.Info($"Обновлены размеры парковки");
                }
            }
            catch (Exception ex)
            {
                LoG.Info($"Неизвестная ошибка. {ex.Message}");
                MessageBox.Show(ex.Message, "Неизвестная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary> Метод. Отрисовка парковки </summary>
        private void NewDraw()
        {
            try
            {
                parking = new MultiLevelParking(countLevel, new Size(pictureBoxParking.Width, pictureBoxParking.Height));

                // Заполнение listBox
                for (int i = 0; i < countLevel; i++) ListLevels.Items.Add("Уровень " + (i + 1));
                ListLevels.SelectedIndex = 0;

                LoG.Info($"Создана парковка");
            }
            catch (Exception ex)
            {
                LoG.Info($"Неизвестная ошибка. {ex.Message}");
                MessageBox.Show(ex.Message, "Неизвестная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary> Метод. отрисовка парковки </summary>
        private void Draw()
        {
            try
            {
                if (ListLevels.SelectedIndex > -1)
                {
                    Bitmap bmp = new Bitmap(pictureBoxParking.Width, pictureBoxParking.Height);
                    Graphics gr = Graphics.FromImage(bmp);

                    parking[ListLevels.SelectedIndex].Draw(gr); pictureBoxParking.Image = bmp;

                    LoG.Info($"Прорисовка парковки");
                }
            }
            catch (Exception ex)
            {
                LoG.Info($"Неизвестная ошибка. {ex.Message}");
                MessageBox.Show(ex.Message, "Неизвестная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ListLevels_SelectedIndexChanged(object sender, EventArgs e) => Draw();

        /// <summary>  Обработка нажатия кнопки «Создать транспорт»</summary>
        private void Button_SetTransport_Click(object sender, EventArgs e)
        {
            Form_TransportConfig SetForm = new Form_TransportConfig();
            SetForm.AddEvent(AddCar); SetForm.Show();
        }

        /// <summary> Метод добавления машины </summary>
        private void AddCar(ITransport Transport)
        {
            try
            {
                if (Transport != null && ListLevels.SelectedIndex > -1)
                {
                    int Result = parking[ListLevels.SelectedIndex] + Transport;

                    if (Result > -1)
                    {
                        Draw();
                        LoG.Info($"Транспорт добавлен на уровнь [{ListLevels.SelectedIndex}] на место [{Result}]");
                    }
                    else throw new Exceptions.Errors.FailedCreateTransport();
                }
            }
            catch (Exceptions.Errors.FailedCreateTransport ex)
            {
                LoG.Info($"{ex.Data["Kod"]}. {ex.Message}");
                MessageBox.Show(ex.Message, ex.Data["Kod"].ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                LoG.Info($"Неизвестная ошибка. {ex.Message}");
                MessageBox.Show(ex.Message, "Неизвестная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary> Обработка нажатия кнопки «Изъять транспорт»</summary>
        private void Button_UPTransport_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                try
                {
                    var Transport = parking[ListLevels.SelectedIndex] - Convert.ToInt32(textBox1.Text);
                    if (Transport != null)
                    {
                        Bitmap bmp = new Bitmap(pictureBoxTakeCar.Width, pictureBoxTakeCar.Height);
                        Graphics gr = Graphics.FromImage(bmp);
                        Transport.SetPosition(new Point(5, 5), new Size(pictureBoxTakeCar.Width, pictureBoxTakeCar.Height));
                        Transport.Draw(gr); pictureBoxTakeCar.Image = bmp;
                    }
                    else
                    {
                        Bitmap bmp = new Bitmap(pictureBoxTakeCar.Width, pictureBoxTakeCar.Height);
                        pictureBoxTakeCar.Image = bmp;
                    }
                    Draw();

                    LoG.Info($"Транспорт изъят на уровне [{ListLevels.SelectedIndex}] на месте [{textBox1.Text}]");
                }
                catch (Exceptions.Errors.NoParkingPlaceFound ex)
                {
                    LoG.Info($"{ex.Data["Kod"]}. {ex.Message}");
                    MessageBox.Show(ex.Message, ex.Data["Kod"].ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    LoG.Info($"Неизвестная ошибка. {ex.Message}");
                    MessageBox.Show(ex.Message, "Неизвестная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary> Обработка нажатия кнопки «Сохранить»</summary>
        private void Button_Save_Click(object sender, EventArgs e)
            => parking.SaveData($@"{Application.StartupPath}");

        /// <summary> Обработка нажатия кнопки «Загрузить»</summary>
        private void Button_Load_Click(object sender, EventArgs e)
        {
            try
            {
                if (parking.LoadData($@"{Application.StartupPath}"))
                { new Exceptions.Information.LoadData(); Draw(); }
                else throw new Exceptions.Errors.LoadData();
            }
            catch (Exceptions.Information.LoadData ex)
            {
                LoG.Info($"{ex.Data["Say"]}. {ex.Message}");
                MessageBox.Show(ex.Message, ex.Data["Say"].ToString(), MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exceptions.Errors.LoadData ex)
            {
                LoG.Info($"{ex.Data["Kod"]}. {ex.Message}");
                MessageBox.Show(ex.Message, ex.Data["Kod"].ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                LoG.Info($"Неизвестная ошибка. {ex.Message}");
                MessageBox.Show(ex.Message, "Неизвестная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}