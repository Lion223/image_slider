using System;
using System.Linq;

namespace it_kr
{
    class ImageSliderController
    {
        private static ImageSliderModel model;
        private static ImageSliderView view;

        public ImageSliderController(ImageSliderModel m, ImageSliderView v)
        {
            model = m;
            view = v;

            view.formLoad(new EventHandler(mainForm_Load));
            view.fileBtnClick(new EventHandler(fileBtn_Click));
            view.leftBtnClick(new EventHandler(leftBtn_Click));
            view.rightBtnClick(new EventHandler(rightBtn_Click));
            view.timerTick(new EventHandler(timer_Tick));
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            view.ofd.Title = "Load images into slider";
            view.ofd.Filter = "Images (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";
            view.ofd.FileName = "";
        }

        private void fileBtn_Click(object sender, EventArgs e)
        {
            if (view.ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                foreach (string filename in view.ofd.FileNames)
                {
                    model.IMAGE_PATHS.Add(filename);
                }
                view.posLbl.Text = (model.IMAGE_POSITION + 1).ToString();
                view.nameLbl.Text = model.IMAGE_PATHS.First();
                model.IMAGE_COUNT = model.IMAGE_PATHS.Count;
                view.sliderPB.Maximum = model.IMAGE_COUNT;
                view.sliderPB.Value++;

                playSlider();
                view.timer.Enabled = true;
            }

        }

        private void leftBtn_Click(object sender, EventArgs e)
        {
            view.timer.Interval = 5000;
            view.timer.Stop();
            view.timer.Start();
            model.IMAGE_POSITION--;
            playSlider();
        }

        private void rightBtn_Click(object sender, EventArgs e)
        {
            view.timer.Interval = 5000;
            view.timer.Stop();
            view.timer.Start();
            model.IMAGE_POSITION++;
            playSlider();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            view.timer.Interval = 3000;
            model.IMAGE_POSITION++;
            playSlider();
        }

        private void playSlider()
        {
            if (model.IMAGE_POSITION < 0)
                model.IMAGE_POSITION = model.IMAGE_COUNT - 1;
            if (model.IMAGE_POSITION >= model.IMAGE_COUNT)
                model.IMAGE_POSITION = 0;

            view.posLbl.Text = (model.IMAGE_POSITION + 1).ToString();
            view.nameLbl.Text = model.IMAGE_PATHS.ElementAt(model.IMAGE_POSITION);
            view.sliderPB.Value = model.IMAGE_POSITION + 1;

            view.imgSlider.ImageLocation = model.IMAGE_PATHS.ElementAt(model.IMAGE_POSITION);
        }
    }
}
