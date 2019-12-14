using System.Collections.Generic;

namespace it_kr
{
    //Model
    public class ImageSliderModel
    {
        public int IMAGE_POSITION { get; set; }
        public int IMAGE_COUNT { get; set; }
        public List<string> IMAGE_PATHS { get; set; }

        public ImageSliderModel()
        {
            IMAGE_POSITION = 0;
            IMAGE_COUNT = 0;
            IMAGE_PATHS = new List<string>();
        }

    }
}
