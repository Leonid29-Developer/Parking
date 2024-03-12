namespace Test135
{
    partial class FormParking
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
            this.pictureBoxParking = new System.Windows.Forms.PictureBox();
            this.Create1 = new System.Windows.Forms.Button();
            this.Create2 = new System.Windows.Forms.Button();
            this.Create3 = new System.Windows.Forms.Button();
            this.pictureBoxTakeCar = new System.Windows.Forms.PictureBox();
            this.UP = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ListLevels = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AddBegin = new System.Windows.Forms.Button();
            this.AddEnd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTakeCar)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxParking
            // 
            this.pictureBoxParking.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxParking.Location = new System.Drawing.Point(13, 13);
            this.pictureBoxParking.Margin = new System.Windows.Forms.Padding(10);
            this.pictureBoxParking.Name = "pictureBoxParking";
            this.pictureBoxParking.Size = new System.Drawing.Size(962, 672);
            this.pictureBoxParking.TabIndex = 0;
            this.pictureBoxParking.TabStop = false;
            // 
            // Create1
            // 
            this.Create1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Create1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Create1.Location = new System.Drawing.Point(988, 151);
            this.Create1.Margin = new System.Windows.Forms.Padding(12);
            this.Create1.Name = "Create1";
            this.Create1.Size = new System.Drawing.Size(220, 50);
            this.Create1.TabIndex = 1;
            this.Create1.Text = "Создать транспорт #1";
            this.Create1.UseVisualStyleBackColor = true;
            this.Create1.Click += new System.EventHandler(this.buttonSetCar_Click);
            // 
            // Create2
            // 
            this.Create2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Create2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Create2.Location = new System.Drawing.Point(988, 225);
            this.Create2.Margin = new System.Windows.Forms.Padding(12);
            this.Create2.Name = "Create2";
            this.Create2.Size = new System.Drawing.Size(220, 50);
            this.Create2.TabIndex = 2;
            this.Create2.Text = "Создать транспорт #2";
            this.Create2.UseVisualStyleBackColor = true;
            this.Create2.Click += new System.EventHandler(this.buttonSetSportCar_Click);
            // 
            // Create3
            // 
            this.Create3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Create3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Create3.Location = new System.Drawing.Point(988, 299);
            this.Create3.Margin = new System.Windows.Forms.Padding(12);
            this.Create3.Name = "Create3";
            this.Create3.Size = new System.Drawing.Size(220, 50);
            this.Create3.TabIndex = 3;
            this.Create3.Text = "Создать транспорт #3";
            this.Create3.UseVisualStyleBackColor = true;
            this.Create3.Click += new System.EventHandler(this.buttonSetCruiser_Click);
            // 
            // pictureBoxTakeCar
            // 
            this.pictureBoxTakeCar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxTakeCar.Location = new System.Drawing.Point(988, 565);
            this.pictureBoxTakeCar.Margin = new System.Windows.Forms.Padding(12, 12, 12, 25);
            this.pictureBoxTakeCar.Name = "pictureBoxTakeCar";
            this.pictureBoxTakeCar.Size = new System.Drawing.Size(220, 120);
            this.pictureBoxTakeCar.TabIndex = 4;
            this.pictureBoxTakeCar.TabStop = false;
            // 
            // UP
            // 
            this.UP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.UP.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UP.Location = new System.Drawing.Point(988, 454);
            this.UP.Margin = new System.Windows.Forms.Padding(12);
            this.UP.Name = "UP";
            this.UP.Size = new System.Drawing.Size(220, 45);
            this.UP.TabIndex = 5;
            this.UP.Text = "Забрать транспорт";
            this.UP.UseVisualStyleBackColor = true;
            this.UP.Click += new System.EventHandler(this.buttonTakeCar_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(1060, 417);
            this.textBox1.Margin = new System.Windows.Forms.Padding(12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(75, 29);
            this.textBox1.TabIndex = 6;
            // 
            // ListLevels
            // 
            this.ListLevels.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ListLevels.FormattingEnabled = true;
            this.ListLevels.Location = new System.Drawing.Point(988, 41);
            this.ListLevels.Name = "ListLevels";
            this.ListLevels.Size = new System.Drawing.Size(220, 95);
            this.ListLevels.TabIndex = 7;
            this.ListLevels.SelectedIndexChanged += new System.EventHandler(this.ListLevels_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(988, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Текущий уровень парковки";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddBegin
            // 
            this.AddBegin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddBegin.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddBegin.Location = new System.Drawing.Point(988, 509);
            this.AddBegin.Margin = new System.Windows.Forms.Padding(12);
            this.AddBegin.Name = "AddBegin";
            this.AddBegin.Size = new System.Drawing.Size(108, 45);
            this.AddBegin.TabIndex = 9;
            this.AddBegin.Text = "Добавить в начало";
            this.AddBegin.UseVisualStyleBackColor = true;
            // 
            // AddEnd
            // 
            this.AddEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddEnd.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddEnd.Location = new System.Drawing.Point(1100, 509);
            this.AddEnd.Margin = new System.Windows.Forms.Padding(12);
            this.AddEnd.Name = "AddEnd";
            this.AddEnd.Size = new System.Drawing.Size(108, 45);
            this.AddEnd.TabIndex = 10;
            this.AddEnd.Text = "Добавить в конец";
            this.AddEnd.UseVisualStyleBackColor = true;
            // 
            // FormParking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 697);
            this.Controls.Add(this.AddEnd);
            this.Controls.Add(this.AddBegin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ListLevels);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.UP);
            this.Controls.Add(this.pictureBoxTakeCar);
            this.Controls.Add(this.Create3);
            this.Controls.Add(this.Create2);
            this.Controls.Add(this.Create1);
            this.Controls.Add(this.pictureBoxParking);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormParking";
            this.Text = "FormParking";
            this.SizeChanged += new System.EventHandler(this.FormParking_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTakeCar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxParking;
        private System.Windows.Forms.Button Create1;
        private System.Windows.Forms.Button Create2;
        private System.Windows.Forms.Button Create3;
        private System.Windows.Forms.PictureBox pictureBoxTakeCar;
        private System.Windows.Forms.Button UP;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox ListLevels;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddBegin;
        private System.Windows.Forms.Button AddEnd;
    }
}