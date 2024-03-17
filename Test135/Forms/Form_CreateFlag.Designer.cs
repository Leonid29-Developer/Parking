namespace Test135
{
    partial class Form_CreateFlag
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.CellColor = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Picture_Flag = new System.Windows.Forms.PictureBox();
            this.Button_Сancel = new System.Windows.Forms.Button();
            this.Button_Create = new System.Windows.Forms.Button();
            this.CellColor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_Flag)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(273, 394);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 23);
            this.label1.TabIndex = 69;
            this.label1.Text = "Цвет";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CellColor
            // 
            this.CellColor.AllowDrop = true;
            this.CellColor.BackColor = System.Drawing.Color.White;
            this.CellColor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CellColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CellColor.Controls.Add(this.pictureBox1);
            this.CellColor.Location = new System.Drawing.Point(368, 386);
            this.CellColor.Margin = new System.Windows.Forms.Padding(12);
            this.CellColor.Name = "CellColor";
            this.CellColor.Size = new System.Drawing.Size(40, 40);
            this.CellColor.TabIndex = 68;
            this.CellColor.Click += new System.EventHandler(this.MainColor_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(-194, -178);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(12, 12, 12, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 120);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(423, 394);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 23);
            this.label2.TabIndex = 70;
            this.label2.Text = "Предпросмотр";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Picture_Flag
            // 
            this.Picture_Flag.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Picture_Flag.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Picture_Flag.Location = new System.Drawing.Point(570, 399);
            this.Picture_Flag.Margin = new System.Windows.Forms.Padding(10);
            this.Picture_Flag.Name = "Picture_Flag";
            this.Picture_Flag.Size = new System.Drawing.Size(19, 13);
            this.Picture_Flag.TabIndex = 71;
            this.Picture_Flag.TabStop = false;
            // 
            // Button_Сancel
            // 
            this.Button_Сancel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_Сancel.Location = new System.Drawing.Point(146, 382);
            this.Button_Сancel.Name = "Button_Сancel";
            this.Button_Сancel.Size = new System.Drawing.Size(105, 48);
            this.Button_Сancel.TabIndex = 73;
            this.Button_Сancel.Text = "Отмена";
            this.Button_Сancel.UseVisualStyleBackColor = true;
            this.Button_Сancel.Click += new System.EventHandler(this.Button_Сancel_Click);
            // 
            // Button_Create
            // 
            this.Button_Create.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_Create.Location = new System.Drawing.Point(31, 382);
            this.Button_Create.Name = "Button_Create";
            this.Button_Create.Size = new System.Drawing.Size(101, 48);
            this.Button_Create.TabIndex = 72;
            this.Button_Create.Text = "Создать";
            this.Button_Create.UseVisualStyleBackColor = true;
            this.Button_Create.Click += new System.EventHandler(this.Button_Create_Click);
            // 
            // Form_CreateFlag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 447);
            this.Controls.Add(this.Button_Сancel);
            this.Controls.Add(this.Button_Create);
            this.Controls.Add(this.Picture_Flag);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CellColor);
            this.Name = "Form_CreateFlag";
            this.Load += new System.EventHandler(this.Form_CreateFlag_Load);
            this.CellColor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_Flag)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel CellColor;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox Picture_Flag;
        private System.Windows.Forms.Button Button_Сancel;
        private System.Windows.Forms.Button Button_Create;
    }
}