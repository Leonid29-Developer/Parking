namespace Test135
{
    partial class Form_Interface
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.PictureTransport = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureTransport)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureTransport
            // 
            this.PictureTransport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PictureTransport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureTransport.Location = new System.Drawing.Point(0, 0);
            this.PictureTransport.Name = "PictureTransport";
            this.PictureTransport.Size = new System.Drawing.Size(900, 500);
            this.PictureTransport.TabIndex = 0;
            this.PictureTransport.TabStop = false;
            // 
            // Form_Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.PictureTransport);
            this.Name = "Form_Interface";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Интерфейс";
            this.Load += new System.EventHandler(this.Form_Interface_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Interface_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.PictureTransport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureTransport;
    }
}

