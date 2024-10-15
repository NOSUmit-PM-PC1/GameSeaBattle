namespace GameSeaBattle
{
    partial class FormGame
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGame));
            this.pictureBoxSea = new System.Windows.Forms.PictureBox();
            this.pictureBoxShip = new System.Windows.Forms.PictureBox();
            this.timerShip = new System.Windows.Forms.Timer(this.components);
            this.pictureBoxTorpedo = new System.Windows.Forms.PictureBox();
            this.timerTorpedo = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTorpedo)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxSea
            // 
            this.pictureBoxSea.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBoxSea.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSea.Image")));
            this.pictureBoxSea.Location = new System.Drawing.Point(0, 112);
            this.pictureBoxSea.Name = "pictureBoxSea";
            this.pictureBoxSea.Size = new System.Drawing.Size(1098, 487);
            this.pictureBoxSea.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSea.TabIndex = 0;
            this.pictureBoxSea.TabStop = false;
            // 
            // pictureBoxShip
            // 
            this.pictureBoxShip.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxShip.Image")));
            this.pictureBoxShip.Location = new System.Drawing.Point(284, 12);
            this.pictureBoxShip.Name = "pictureBoxShip";
            this.pictureBoxShip.Size = new System.Drawing.Size(100, 97);
            this.pictureBoxShip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxShip.TabIndex = 1;
            this.pictureBoxShip.TabStop = false;
            // 
            // timerShip
            // 
            this.timerShip.Enabled = true;
            this.timerShip.Interval = 10;
            this.timerShip.Tick += new System.EventHandler(this.timerShip_Tick);
            // 
            // pictureBoxTorpedo
            // 
            this.pictureBoxTorpedo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxTorpedo.Image")));
            this.pictureBoxTorpedo.Location = new System.Drawing.Point(323, 557);
            this.pictureBoxTorpedo.Name = "pictureBoxTorpedo";
            this.pictureBoxTorpedo.Size = new System.Drawing.Size(61, 86);
            this.pictureBoxTorpedo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxTorpedo.TabIndex = 2;
            this.pictureBoxTorpedo.TabStop = false;
            // 
            // timerTorpedo
            // 
            this.timerTorpedo.Interval = 10;
            this.timerTorpedo.Tick += new System.EventHandler(this.timerTorpedo_Tick);
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1098, 599);
            this.Controls.Add(this.pictureBoxTorpedo);
            this.Controls.Add(this.pictureBoxShip);
            this.Controls.Add(this.pictureBoxSea);
            this.KeyPreview = true;
            this.Name = "FormGame";
            this.Text = "Морской бой";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormGame_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTorpedo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxSea;
        private System.Windows.Forms.PictureBox pictureBoxShip;
        private System.Windows.Forms.Timer timerShip;
        private System.Windows.Forms.PictureBox pictureBoxTorpedo;
        private System.Windows.Forms.Timer timerTorpedo;
    }
}

