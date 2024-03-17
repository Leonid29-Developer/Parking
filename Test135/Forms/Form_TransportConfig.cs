using System;
using System.Drawing;
using System.Windows.Forms;

namespace Test135
{
    public partial class Form_TransportConfig : Form
    {
        /// <summary> Переменная-выбранная машина </summary>
        ITransport Transport = null;

        /// <summary> Событие </summary>
        private event TransportDelegate EventAddCar;

        public Form_TransportConfig()
        {
            InitializeComponent(); Size = new Size(595, 310);
            Picture_Transport.Location = new Point(12, 48); Button_CreateFlag.Visible = false;
        }

        /// <summary> Метод. Отрисовка транспорта</summary>
        private void Draw()
        {
            try
            {
                if (Transport != null)
                {
                    Bitmap bmp = new Bitmap(Picture_Transport.Width, Picture_Transport.Height);
                    Graphics gr = Graphics.FromImage(bmp); Textures.Drawing(gr, Transport);
                    Picture_Transport.Image = bmp;

                    Form_Parking.LoG.Info($"Прорисовка транспорта");
                }
            }
            catch (Exception ex)
            {
                Form_Parking.LoG.Info($"Неизвестная ошибка. {ex.Message}");
                MessageBox.Show(ex.Message, "Неизвестная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary> Добавление события </summary>
        public void AddEvent(TransportDelegate ev)
        {
            if (EventAddCar == null) EventAddCar = new TransportDelegate(ev);
            else EventAddCar += ev;
        }

        /// <summary> Передаем информацию при нажатии на Label </summary>
        private void labelTransport_MouseDown(object sender, MouseEventArgs e)
        { (sender as Control).DoDragDrop((sender as Control).Tag, DragDropEffects.Move | DragDropEffects.Copy); }

        /// <summary> Проверка получаемой информации (ее типа на соответствие требуемому) </summary>
        private void panelCar_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text)) e.Effect = DragDropEffects.Copy;
            else e.Effect = DragDropEffects.None;
        }

        /// <summary> Действия при приеме перетаскиваемой информации  </summary>
        private void panelCar_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                Random Rand = new Random();

                switch (e.Data.GetData(DataFormats.Text).ToString())
                {
                    case "Car":
                        {
                            Transport = new Car(Transports.Car, 100, 1000, Color.White);
                            Size = new Size(595, 373); Picture_Transport.Location = new Point(12, 48);
                            Button_CreateFlag.Visible = false;
                        }
                        break;

                    case "SportCar":
                        {
                            Transport = new SportCar(Transports.SportCar, 100, 1000, Color.Red, Color.Black, Rand.Next(1, 4), Color.White);
                            Size = new Size(595, 522); Picture_Transport.Location = new Point(12, 48);
                            Button_CreateFlag.Visible = false;
                        }
                        break;

                    case "Cruiser":
                        {
                            Bitmap BM_Flag = new Bitmap(15, 9); Graphics Grap_Flag = Graphics.FromImage(BM_Flag);

                            Grap_Flag.FillRectangle(new SolidBrush(Color.White), 0, 0, 15, 3);
                            Grap_Flag.FillRectangle(new SolidBrush(Color.Blue), 0, 3, 15, 3);
                            Grap_Flag.FillRectangle(new SolidBrush(Color.Red), 0, 6, 15, 3);
                            Grap_Flag.FillRectangle(new SolidBrush(Color.Gold), 10, 3, 3, 3);

                            Transport = new Cruiser(Transports.Cruiser, 100, 1000, Color.Red, BM_Flag);
                            Size = new Size(595, 373); Picture_Transport.Location = new Point(12, 15);
                            Button_CreateFlag.Visible = true;
                        }
                        break;
                }

                MainColor.BackColor = BackColor;
                DopColor.BackColor = BackColor;
                LineColor.BackColor = BackColor;

                Point Offset = new Point(0, 0);
                switch (Transport.GetTypeTransport())
                {
                    case Transports.Car: Offset = new Point(60, 30); break;
                    case Transports.SportCar: Offset = new Point(55, 25); break;
                    default: Offset = new Point(0, 0); break;
                }

                Transport.SetPosition(new Point(Offset.X, Offset.Y), new Size(0, 0));
                Draw();

                Form_Parking.LoG.Info($"Создание предпросмотра транспорта по умолчанию");
            }
            catch (Exception ex)
            {
                Form_Parking.LoG.Info($"Неизвестная ошибка. {ex.Message}");
                MessageBox.Show(ex.Message, "Неизвестная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary> Назначение нового цвета транспорту </summary>
        private void SetColor_Click(object sender, EventArgs e)
        {
            try
            {
                TypesСolors Type = TypesСolors.MainColor;

                switch ((sender as Control).Name)
                {
                    case "DopColor": Type = TypesСolors.DopColor; break;
                    case "LineColor": Type = TypesСolors.LineColor; break;
                }

                ColorDialog dialog = new ColorDialog();
                if (dialog.ShowDialog() == DialogResult.OK) Transport.SetColor(dialog.Color, Type);
                (sender as Control).BackColor = dialog.Color; Draw();
            }
            catch (Exception ex)
            {
                Form_Parking.LoG.Info($"Неизвестная ошибка. {ex.Message}");
                MessageBox.Show(ex.Message, "Неизвестная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Button_CreateFlag_Click(object sender, EventArgs e)
        {
            Form_CreateFlag SetForm = new Form_CreateFlag();
            SetForm.AddEvent(SetFlag); SetForm.Show();
        }

        private void SetFlag(Bitmap BM)
        {
            Form_Parking.LoG.Info($"Создание индивидуального флага для текущего транспорта [{Transport.GetTypeTransport()}]");
            Transport.FlagBM = BM; Draw(); 
        }

        /// <summary> Добавление транспорта на парковку </summary>
        private void Button_Create_Click(object sender, EventArgs e)
        { EventAddCar.Invoke(Transport); Close(); }

        /// <summary> Отмена добавления транспорта </summary>
        private void Button_Сancel_Click(object sender, EventArgs e) => Close();
    }
}