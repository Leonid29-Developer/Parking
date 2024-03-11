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
            this.Create1.Location = new System.Drawing.Point(988, 34);
            this.Create1.Margin = new System.Windows.Forms.Padding(25);
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
            this.Create2.Location = new System.Drawing.Point(988, 134);
            this.Create2.Margin = new System.Windows.Forms.Padding(25);
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
            this.Create3.Location = new System.Drawing.Point(988, 234);
            this.Create3.Margin = new System.Windows.Forms.Padding(25);
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
            this.pictureBoxTakeCar.Location = new System.Drawing.Point(988, 543);
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
            this.UP.Location = new System.Drawing.Point(988, 474);
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
            this.textBox1.Location = new System.Drawing.Point(1061, 435);
            this.textBox1.Margin = new System.Windows.Forms.Padding(12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(75, 29);
            this.textBox1.TabIndex = 6;
            // 
            // FormParking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 697);
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
    }
}