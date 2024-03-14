using System;
using System.Drawing;
using System.Windows.Forms;

namespace Test135
{
    public partial class FormParking : Form
    {
        /// <summary> Объект от класса многоуровневой парковки </summary>
        MultiLevelParking parking;

        /// <summary> Количество уровней-парковок </summary>
        private const int countLevel = 6;

        public FormParking()
        { InitializeComponent(); NewDraw(); }

        ///<summary> Обработка изменения размера формы </summary>
        private void FormParking_Resize(object sender, EventArgs e)
        {
            if (Width > 160 & Height > 30)
            {
                for (int i = 0; i < countLevel; i++)
                {
                    parking[i].Resize(new Size(pictureBoxParking.Width, pictureBoxParking.Height));
                    _ = parking[i] ^ 1;
                }
                Draw();
            }
        }

        /// <summary> Метод. Отрисовка парковки </summary>
        private void NewDraw()
        {
            parking = new MultiLevelParking(countLevel, new Size(pictureBoxParking.Width, pictureBoxParking.Height));

            // Заполнение listBox
            for (int i = 0; i < countLevel; i++)
                ListLevels.Items.Add("Уровень " + (i + 1));
            ListLevels.SelectedIndex = 0;

            Draw();
        }

        /// <summary> Метод. отрисовка парковки </summary>
        private void Draw()
        {
            if (ListLevels.SelectedIndex > -1)
            {
                Bitmap bmp = new Bitmap(pictureBoxParking.Width, pictureBoxParking.Height);
                Graphics gr = Graphics.FromImage(bmp);


                parking[ListLevels.SelectedIndex].Draw(gr); pictureBoxParking.Image = bmp;
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
            if (Transport != null && ListLevels.SelectedIndex > -1)
                if (parking[ListLevels.SelectedIndex] + Transport > -1) Draw();
                else
                    MessageBox.Show("Не удалось создать транспорт", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private ITransport Temp_Transport { get; set; }

        /// <summary> Обработка нажатия кнопки «Забрать транспорт»</summary>
        private void Button_UPTransport_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                var Transport = parking[ListLevels.SelectedIndex] - Convert.ToInt32(textBox1.Text);
                Temp_Transport = Transport;
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
            }
        }

        /// <summary> Обработка нажатия кнопки «Забыть транспорт»</summary>
        private void Button_ClearTransport_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBoxTakeCar.Width, pictureBoxTakeCar.Height);
            pictureBoxTakeCar.Image = bmp; Temp_Transport = null;
        }

        /// <summary> Обработка нажатия кнопки «Сохранить»</summary>
        private void Button_Save_Click(object sender, EventArgs e)
            => parking.SaveData($@"{Application.StartupPath}");

        /// <summary> Обработка нажатия кнопки «Загрузить»</summary>
        private void Button_Load_Click(object sender, EventArgs e)
        {
            if (parking.LoadData($@"{Application.StartupPath}"))
            { new Loggers.Message.Information.LoadData(); Draw(); }
            else new Loggers.Message.Errors.LoadData();
        }
    }
}