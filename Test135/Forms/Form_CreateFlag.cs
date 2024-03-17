using System;
using System.Drawing;
using System.Windows.Forms;

namespace Test135
{
    public partial class Form_CreateFlag : Form
    {
        public Form_CreateFlag() => InitializeComponent();

        /// <summary> Событие </summary>
        private event FlagDelegate EventSetFlag;

        /// <summary>  Изображения флага </summary>
        private Bitmap BiM_Flag;

        /// <summary> Используемый цвет </summary>
        private Color PaintColor = Color.White;

        private void Form_CreateFlag_Load(object sender, EventArgs e)
        {
            BiM_Flag = new Bitmap(15, 9);

            for (int I1 = 0; I1 < 9; I1++) for (int I2 = 0; I2 < 15; I2++)
                {
                    Panel PaintPanel = new Panel
                    {
                        Name = $"Cell_{I1}_{I2}",
                        Size = new Size(40, 40),
                        BackColor = Color.White,
                        Location = new Point(10 + 40 * I2, 10 + 40 * I1),
                        BorderStyle = BorderStyle.FixedSingle
                    };
                    PaintPanel.Click += SetCellColor; this.Controls.Add(PaintPanel);
                }
        }

        /// <summary> Добавление события </summary>
        public void AddEvent(FlagDelegate ev)
        {
            if (EventSetFlag == null) EventSetFlag = new FlagDelegate(ev);
            else EventSetFlag += ev;
        }

        /// <summary> Назначение нового цвета </summary>
        private void MainColor_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK) PaintColor = dialog.Color;
            CellColor.BackColor = PaintColor;
        }

        /// <summary> Назначение ячейке нового цвета </summary>
        private void SetCellColor(object sender, EventArgs e)
        {
            try
            {
                Panel CellSet = (Panel)sender; Graphics GR_Flag = Graphics.FromImage(BiM_Flag);

                var Cells = CellSet.Name.ToString().Split('_');

                GR_Flag.FillRectangle(new SolidBrush(PaintColor), Convert.ToInt32(Cells[2]), Convert.ToInt32(Cells[1]), 1, 1);

                Picture_Flag.Image = BiM_Flag; CellSet.BackColor = PaintColor;
            }
            catch (Exception ex)
            {
                Form_Parking.LoG.Info($"Неизвестная ошибка. {ex.Message}");
                MessageBox.Show(ex.Message, "Неизвестная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary> Создание флага и добавление на транспорт </summary>
        private void Button_Create_Click(object sender, EventArgs e)
        { EventSetFlag.Invoke(BiM_Flag); Close(); }
        private void Button_Сancel_Click(object sender, EventArgs e) => Close();
    }
}