﻿namespace Test135
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
            this.pictureBoxTakeCar = new System.Windows.Forms.PictureBox();
            this.Button_UPTransport = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ListLevels = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Button_AddBeginTransport = new System.Windows.Forms.Button();
            this.Button_AddEndTransport = new System.Windows.Forms.Button();
            this.Create_Transport = new System.Windows.Forms.Button();
            this.Button_ClearTransport = new System.Windows.Forms.Button();
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
            // Button_UPTransport
            // 
            this.Button_UPTransport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_UPTransport.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_UPTransport.Location = new System.Drawing.Point(988, 431);
            this.Button_UPTransport.Margin = new System.Windows.Forms.Padding(12);
            this.Button_UPTransport.Name = "Button_UPTransport";
            this.Button_UPTransport.Size = new System.Drawing.Size(108, 54);
            this.Button_UPTransport.TabIndex = 5;
            this.Button_UPTransport.Text = "Забрать транспорт";
            this.Button_UPTransport.UseVisualStyleBackColor = true;
            this.Button_UPTransport.Click += new System.EventHandler(this.Button_UPTransport_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(1006, 387);
            this.textBox1.Margin = new System.Windows.Forms.Padding(12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(75, 29);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // Button_AddBeginTransport
            // 
            this.Button_AddBeginTransport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_AddBeginTransport.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_AddBeginTransport.Location = new System.Drawing.Point(988, 500);
            this.Button_AddBeginTransport.Margin = new System.Windows.Forms.Padding(12);
            this.Button_AddBeginTransport.Name = "Button_AddBeginTransport";
            this.Button_AddBeginTransport.Size = new System.Drawing.Size(108, 54);
            this.Button_AddBeginTransport.TabIndex = 9;
            this.Button_AddBeginTransport.Text = "Добавить в начало";
            this.Button_AddBeginTransport.UseVisualStyleBackColor = true;
            this.Button_AddBeginTransport.Click += new System.EventHandler(this.Button_AddBeginTransport_Click);
            // 
            // Button_AddEndTransport
            // 
            this.Button_AddEndTransport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_AddEndTransport.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_AddEndTransport.Location = new System.Drawing.Point(1100, 500);
            this.Button_AddEndTransport.Margin = new System.Windows.Forms.Padding(12);
            this.Button_AddEndTransport.Name = "Button_AddEndTransport";
            this.Button_AddEndTransport.Size = new System.Drawing.Size(108, 54);
            this.Button_AddEndTransport.TabIndex = 10;
            this.Button_AddEndTransport.Text = "Добавить в конец";
            this.Button_AddEndTransport.UseVisualStyleBackColor = true;
            this.Button_AddEndTransport.Click += new System.EventHandler(this.Button_AddEndTransport_Click);
            // 
            // Create_Transport
            // 
            this.Create_Transport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Create_Transport.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Create_Transport.Location = new System.Drawing.Point(988, 151);
            this.Create_Transport.Margin = new System.Windows.Forms.Padding(12);
            this.Create_Transport.Name = "Create_Transport";
            this.Create_Transport.Size = new System.Drawing.Size(220, 50);
            this.Create_Transport.TabIndex = 11;
            this.Create_Transport.Text = "Создать транспорт";
            this.Create_Transport.UseVisualStyleBackColor = true;
            this.Create_Transport.Click += new System.EventHandler(this.Button_SetTransport_Click);
            // 
            // Button_ClearTransport
            // 
            this.Button_ClearTransport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_ClearTransport.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_ClearTransport.Location = new System.Drawing.Point(1100, 431);
            this.Button_ClearTransport.Margin = new System.Windows.Forms.Padding(12);
            this.Button_ClearTransport.Name = "Button_ClearTransport";
            this.Button_ClearTransport.Size = new System.Drawing.Size(108, 54);
            this.Button_ClearTransport.TabIndex = 12;
            this.Button_ClearTransport.Text = "Забыть транспорт";
            this.Button_ClearTransport.UseVisualStyleBackColor = true;
            this.Button_ClearTransport.Click += new System.EventHandler(this.Button_ClearTransport_Click);
            // 
            // FormParking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 697);
            this.Controls.Add(this.Button_ClearTransport);
            this.Controls.Add(this.Create_Transport);
            this.Controls.Add(this.Button_AddEndTransport);
            this.Controls.Add(this.Button_AddBeginTransport);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ListLevels);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Button_UPTransport);
            this.Controls.Add(this.pictureBoxTakeCar);
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
        private System.Windows.Forms.PictureBox pictureBoxTakeCar;
        private System.Windows.Forms.Button Button_UPTransport;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox ListLevels;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Button_AddBeginTransport;
        private System.Windows.Forms.Button Button_AddEndTransport;
        private System.Windows.Forms.Button Create_Transport;
        private System.Windows.Forms.Button Button_ClearTransport;
    }
}