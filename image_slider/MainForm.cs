using System;
using System.Linq;
using System.Windows.Forms;

namespace it_kr
{
    //Controller
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {
        private static ImageSliderModel model;
        public MainForm(ImageSliderModel i)
        {
            InitializeComponent();
            model = i;
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            ofd.Title = "Завантажити зображення у слайдер";
            ofd.Filter = "Зображення (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";
            ofd.FileName = "";
        }

        private void fileBtn_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                foreach (string filename in ofd.FileNames)
                {
                    model.IMAGE_PATHS.Add(filename);
                }
                posLbl.Text = (model.IMAGE_POSITION + 1).ToString();
                nameLbl.Text = model.IMAGE_PATHS.First();
                model.IMAGE_COUNT = model.IMAGE_PATHS.Count;
                sliderPB.Maximum = model.IMAGE_COUNT;
                sliderPB.Value++;

                playSlider();
                timer.Enabled = true;
            }

        }

        private void leftBtn_Click(object sender, EventArgs e)
        {
            timer.Interval = 5000;
            timer.Stop();
            timer.Start();
            model.IMAGE_POSITION--;
            playSlider();

        }

        private void rightBtn_Click(object sender, EventArgs e)
        {
            timer.Interval = 5000;
            timer.Stop();
            timer.Start();
            model.IMAGE_POSITION++;
            playSlider();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            timer.Interval = 3000;
            model.IMAGE_POSITION++;
            playSlider();
        }

        private void playSlider()
        {
            if (model.IMAGE_POSITION < 0)
                model.IMAGE_POSITION = model.IMAGE_COUNT - 1;
            if (model.IMAGE_POSITION >= model.IMAGE_COUNT)
                model.IMAGE_POSITION = 0;

            posLbl.Text = (model.IMAGE_POSITION + 1).ToString();
            nameLbl.Text = model.IMAGE_PATHS.ElementAt(model.IMAGE_POSITION);
            sliderPB.Value = model.IMAGE_POSITION + 1;

            imgSlider.ImageLocation = model.IMAGE_PATHS.ElementAt(model.IMAGE_POSITION);
        }
    }
}
