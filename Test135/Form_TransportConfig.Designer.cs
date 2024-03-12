namespace Test135
{
    partial class Form_TransportConfig
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
            this.Picture_Transport = new System.Windows.Forms.PictureBox();
            this.Transport_Create_1 = new System.Windows.Forms.Label();
            this.Transport_Create_2 = new System.Windows.Forms.Label();
            this.Transport_Create_3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MainColor = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DopColor = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LineColor = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_Transport)).BeginInit();
            this.panel1.SuspendLayout();
            this.MainColor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.DopColor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.LineColor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Picture_Transport
            // 
            this.Picture_Transport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Picture_Transport.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Picture_Transport.Location = new System.Drawing.Point(12, 48);
            this.Picture_Transport.Margin = new System.Windows.Forms.Padding(10);
            this.Picture_Transport.Name = "Picture_Transport";
            this.Picture_Transport.Size = new System.Drawing.Size(220, 120);
            this.Picture_Transport.TabIndex = 7;
            this.Picture_Transport.TabStop = false;
            this.Picture_Transport.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelCar_DragDrop);
            this.Picture_Transport.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelCar_DragEnter);
            // 
            // Transport_Create_1
            // 
            this.Transport_Create_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Transport_Create_1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Transport_Create_1.Location = new System.Drawing.Point(27, 27);
            this.Transport_Create_1.Margin = new System.Windows.Forms.Padding(18);
            this.Transport_Create_1.Name = "Transport_Create_1";
            this.Transport_Create_1.Size = new System.Drawing.Size(220, 50);
            this.Transport_Create_1.TabIndex = 8;
            this.Transport_Create_1.Tag = "Car";
            this.Transport_Create_1.Text = "Создать транспорт #1";
            this.Transport_Create_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Transport_Create_1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelTransport_MouseDown);
            // 
            // Transport_Create_2
            // 
            this.Transport_Create_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Transport_Create_2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Transport_Create_2.Location = new System.Drawing.Point(27, 113);
            this.Transport_Create_2.Margin = new System.Windows.Forms.Padding(18);
            this.Transport_Create_2.Name = "Transport_Create_2";
            this.Transport_Create_2.Size = new System.Drawing.Size(220, 50);
            this.Transport_Create_2.TabIndex = 9;
            this.Transport_Create_2.Tag = "SportCar";
            this.Transport_Create_2.Text = "Создать транспорт #2";
            this.Transport_Create_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Transport_Create_2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelTransport_MouseDown);
            // 
            // Transport_Create_3
            // 
            this.Transport_Create_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Transport_Create_3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Transport_Create_3.Location = new System.Drawing.Point(27, 199);
            this.Transport_Create_3.Margin = new System.Windows.Forms.Padding(18);
            this.Transport_Create_3.Name = "Transport_Create_3";
            this.Transport_Create_3.Size = new System.Drawing.Size(220, 50);
            this.Transport_Create_3.TabIndex = 10;
            this.Transport_Create_3.Tag = "Cruiser";
            this.Transport_Create_3.Text = "Создать транспорт #3";
            this.Transport_Create_3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Transport_Create_3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelTransport_MouseDown);
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Picture_Transport);
            this.panel1.Location = new System.Drawing.Point(304, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(244, 222);
            this.panel1.TabIndex = 11;
            this.panel1.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelCar_DragDrop);
            this.panel1.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelCar_DragEnter);
            // 
            // MainColor
            // 
            this.MainColor.AllowDrop = true;
            this.MainColor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MainColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MainColor.Controls.Add(this.pictureBox1);
            this.MainColor.Location = new System.Drawing.Point(500, 272);
            this.MainColor.Margin = new System.Windows.Forms.Padding(12);
            this.MainColor.Name = "MainColor";
            this.MainColor.Size = new System.Drawing.Size(48, 48);
            this.MainColor.TabIndex = 12;
            this.MainColor.Click += new System.EventHandler(this.SetColor_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(-186, -170);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(12, 12, 12, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 120);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(304, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 23);
            this.label1.TabIndex = 14;
            this.label1.Text = "Основной цвет";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(304, 357);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 23);
            this.label2.TabIndex = 16;
            this.label2.Text = "Дополнительный цвет";
            // 
            // DopColor
            // 
            this.DopColor.AllowDrop = true;
            this.DopColor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DopColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DopColor.Controls.Add(this.pictureBox3);
            this.DopColor.Location = new System.Drawing.Point(500, 344);
            this.DopColor.Margin = new System.Windows.Forms.Padding(12);
            this.DopColor.Name = "DopColor";
            this.DopColor.Size = new System.Drawing.Size(48, 48);
            this.DopColor.TabIndex = 15;
            this.DopColor.Click += new System.EventHandler(this.SetColor_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Location = new System.Drawing.Point(-186, -170);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(12, 12, 12, 25);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(220, 120);
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(304, 429);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 23);
            this.label3.TabIndex = 18;
            this.label3.Text = "Цвет линий";
            // 
            // LineColor
            // 
            this.LineColor.AllowDrop = true;
            this.LineColor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LineColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LineColor.Controls.Add(this.pictureBox2);
            this.LineColor.Location = new System.Drawing.Point(500, 416);
            this.LineColor.Margin = new System.Windows.Forms.Padding(12);
            this.LineColor.Name = "LineColor";
            this.LineColor.Size = new System.Drawing.Size(48, 48);
            this.LineColor.TabIndex = 17;
            this.LineColor.Click += new System.EventHandler(this.SetColor_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(-186, -170);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(12, 12, 12, 25);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(220, 120);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // Form_TransportConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 483);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LineColor);
            this.Controls.Add(this.DopColor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MainColor);
            this.Controls.Add(this.Transport_Create_3);
            this.Controls.Add(this.Transport_Create_2);
            this.Controls.Add(this.Transport_Create_1);
            this.Name = "Form_TransportConfig";
            ((System.ComponentModel.ISupportInitialize)(this.Picture_Transport)).EndInit();
            this.panel1.ResumeLayout(false);
            this.MainColor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.DopColor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.LineColor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox Picture_Transport;
        private System.Windows.Forms.Label Transport_Create_1;
        private System.Windows.Forms.Label Transport_Create_2;
        private System.Windows.Forms.Label Transport_Create_3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel MainColor;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel DopColor;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel LineColor;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}