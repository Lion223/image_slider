using System;

namespace it_kr
{
    class ImageSliderView
    {
        private MetroFramework.Forms.MetroForm form = null;
        private System.ComponentModel.IContainer components = null;


        public MetroFramework.Controls.MetroButton fileBtn { get; set; }
        public MetroFramework.Controls.MetroButton leftBtn { get; set; }
        public MetroFramework.Controls.MetroButton rightBtn { get; set; }
        public System.Windows.Forms.PictureBox imgSlider { get; set; }
        public System.Windows.Forms.Timer timer { get; set; }
        public System.Windows.Forms.OpenFileDialog ofd { get; set; }
        public MetroFramework.Controls.MetroLabel metroLabel1 { get; set; }
        public MetroFramework.Controls.MetroLabel metroLabel2 { get; set; }
        public MetroFramework.Controls.MetroProgressBar sliderPB { get; set; }
        public MetroFramework.Controls.MetroLabel nameLbl { get; set; }
        public MetroFramework.Controls.MetroLabel posLbl { get; set; }

        public ImageSliderView()
        {
            form = new MetroFramework.Forms.MetroForm();
            InitializeComponent();
        }

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
            form.SuspendLayout();
            // 
            // fileBtn
            // 
            this.fileBtn.Location = new System.Drawing.Point(23, 64);
            this.fileBtn.Name = "fileBtn";
            this.fileBtn.Size = new System.Drawing.Size(81, 71);
            this.fileBtn.TabIndex = 0;
            this.fileBtn.Text = "Load images";
            this.fileBtn.UseSelectable = true;
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
            form.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            form.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            form.ClientSize = new System.Drawing.Size(714, 614);
            form.Controls.Add(this.nameLbl);
            form.Controls.Add(this.posLbl);
            form.Controls.Add(this.sliderPB);
            form.Controls.Add(this.metroLabel2);
            form.Controls.Add(this.metroLabel1);
            form.Controls.Add(this.imgSlider);
            form.Controls.Add(this.rightBtn);
            form.Controls.Add(this.leftBtn);
            form.Controls.Add(this.fileBtn);
            form.Name = "mainForm";
            form.Resizable = false;
            form.Text = "Image Slider";
            ((System.ComponentModel.ISupportInitialize)(this.imgSlider)).EndInit();
            form.ResumeLayout(false);
            form.PerformLayout();
        }

        public void formLoad(EventHandler e)
        {
            form.Load += e;
        }

        public void fileBtnClick(EventHandler e)
        {
            fileBtn.Click += e;
        }

        public void leftBtnClick(EventHandler e)
        {
            leftBtn.Click += e;
        }

        public void rightBtnClick(EventHandler e)
        {
            rightBtn.Click += e;
        }

        public void timerTick(EventHandler e)
        {
            timer.Tick += e;
        }
    }
}
