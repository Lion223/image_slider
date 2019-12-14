namespace it_kr
{
    //View
    partial class MainForm
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
            this.fileBtn = new MetroFramework.Controls.MetroButton();
            this.leftBtn = new MetroFramework.Controls.MetroButton();
            this.rightBtn = new MetroFramework.Controls.MetroButton();
            this.imgSlider = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.sliderPB = new MetroFramework.Controls.MetroProgressBar();
            this.nameLbl = new MetroFramework.Controls.MetroLabel();
            this.posLbl = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.imgSlider)).BeginInit();
            this.SuspendLayout();
            // 
            // fileBtn
            // 
            this.fileBtn.Location = new System.Drawing.Point(23, 64);
            this.fileBtn.Name = "fileBtn";
            this.fileBtn.Size = new System.Drawing.Size(81, 71);
            this.fileBtn.TabIndex = 0;
            this.fileBtn.Text = "Load images";
            this.fileBtn.UseSelectable = true;
            this.fileBtn.Click += new System.EventHandler(this.fileBtn_Click);
            // 
            // leftBtn
            // 
            this.leftBtn.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.leftBtn.Location = new System.Drawing.Point(273, 553);
            this.leftBtn.Name = "leftBtn";
            this.leftBtn.Size = new System.Drawing.Size(81, 46);
            this.leftBtn.TabIndex = 1;
            this.leftBtn.Text = "<";
            this.leftBtn.UseSelectable = true;
            this.leftBtn.Click += new System.EventHandler(this.leftBtn_Click);
            // 
            // rightBtn
            // 
            this.rightBtn.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.rightBtn.Location = new System.Drawing.Point(360, 553);
            this.rightBtn.Name = "rightBtn";
            this.rightBtn.Size = new System.Drawing.Size(81, 46);
            this.rightBtn.TabIndex = 2;
            this.rightBtn.Text = ">";
            this.rightBtn.UseSelectable = true;
            this.rightBtn.Click += new System.EventHandler(this.rightBtn_Click);
            // 
            // imgSlider
            // 
            this.imgSlider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.imgSlider.Location = new System.Drawing.Point(24, 141);
            this.imgSlider.Name = "imgSlider";
            this.imgSlider.Size = new System.Drawing.Size(667, 381);
            this.imgSlider.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgSlider.TabIndex = 3;
            this.imgSlider.TabStop = false;
            // 
            // timer
            // 
            this.timer.Interval = 3000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // ofd
            // 
            this.ofd.FileName = "openFileDialog1";
            this.ofd.Multiselect = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(110, 64);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(57, 19);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "Position:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(110, 83);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(89, 19);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "Image Name:";
            // 
            // sliderPB
            // 
            this.sliderPB.Location = new System.Drawing.Point(24, 528);
            this.sliderPB.Maximum = 6;
            this.sliderPB.Name = "sliderPB";
            this.sliderPB.Size = new System.Drawing.Size(667, 19);
            this.sliderPB.Step = 1;
            this.sliderPB.TabIndex = 6;
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Location = new System.Drawing.Point(205, 83);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(0, 0);
            this.nameLbl.TabIndex = 8;
            // 
            // posLbl
            // 
            this.posLbl.AutoSize = true;
            this.posLbl.Location = new System.Drawing.Point(205, 64);
            this.posLbl.Name = "posLbl";
            this.posLbl.Size = new System.Drawing.Size(0, 0);
            this.posLbl.TabIndex = 7;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 614);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.posLbl);
            this.Controls.Add(this.sliderPB);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.imgSlider);
            this.Controls.Add(this.rightBtn);
            this.Controls.Add(this.leftBtn);
            this.Controls.Add(this.fileBtn);
            this.Name = "mainForm";
            this.Resizable = false;
            this.Text = "Image Slider";
            this.Load += new System.EventHandler(this.mainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgSlider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton fileBtn;
        private MetroFramework.Controls.MetroButton leftBtn;
        private MetroFramework.Controls.MetroButton rightBtn;
        private System.Windows.Forms.PictureBox imgSlider;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.OpenFileDialog ofd;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroProgressBar sliderPB;
        private MetroFramework.Controls.MetroLabel nameLbl;
        private MetroFramework.Controls.MetroLabel posLbl;
    }
}

