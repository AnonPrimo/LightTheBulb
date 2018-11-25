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
            Rect.MouseDown += Rect_MouseDown;
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

        //rectangle rotate
        private void Rect_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Rectangle current = (sender as Rectangle);
            Angle += 90;
            RotateTransform rotate = new RotateTransform(Angle, current.Width / 2, current.Height / 2);
            current.RenderTransform = rotate;

            if (Angle == 360)
                Angle = 0;

           // System.Diagnostics.Debug.WriteLine("angle = {0}", Angle);
        }
        
        public void DisableRect()
        {
            if (Angle == 0)
                Rect.IsEnabled = false;
        }

    }
}
