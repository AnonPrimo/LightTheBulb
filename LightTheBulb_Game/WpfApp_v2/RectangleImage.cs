using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using static System.Net.Mime.MediaTypeNames;

namespace WpfApp_v2
{
    class RectangleImage
    {
        public Rectangle Rect { get; set; }
        public ImageBrush Image { get; }
        public int Angle { get; set;}

        public RectangleImage(CroppedBitmap im, int angle)
        {
            Image.ImageSource = im;
            Angle = angle;
            Rect = new Rectangle();
            Rect.Fill = new ImageBrush(im);
        }

        public void Rotate()
        {
            RotateTransform rotate = new RotateTransform(Angle, Rect.Width / 2, Rect.Height / 2);
            Rect.RenderTransform = rotate;
        }
    }
}
