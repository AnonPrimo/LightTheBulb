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
        public CroppedBitmap Image { get; set; }
        public int Angle { get; set; }

        public RectangleImage(CroppedBitmap im)
        {
            Angle = 0;
            Image = im;
            Rect = new Rectangle();
            Rect.Height = im.Height;
            Rect.Width = im.Width;
            Rect.Fill = new ImageBrush(im);
        }

        public void Rotate(int angle)
        {
            Angle = angle;
            RotateTransform rotate = new RotateTransform(angle, Rect.Width / 2, Rect.Height / 2);
            Rect.RenderTransform = rotate;
        }
    }
}
