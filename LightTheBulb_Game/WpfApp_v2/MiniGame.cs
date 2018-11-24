using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp_v2
{
    public class MiniGame
    {
        BitmapImage image;
        RectangleImage[,] field;
        int w, h;
        int Angle;

        public MiniGame(BitmapImage im, int x, int y)
        {
            w = x;
            h = y;
            image = im;
            Angle = 90;
        }

        private void imageCut()
        {        
            field = new RectangleImage[w, h];
            for (int i = 0; i < w; i++)
            {
                for(int j = 0; j < h; j++)
                {
                    field[i, j] = new RectangleImage(new CroppedBitmap(image, new System.Windows.Int32Rect(j+w, i+h, (int)image.Width/w, (int)image.Height)), Angle);
                }
            }
        }

        public bool ImageCheck()
        {
            for(int i = 0; i < w; i++)
            {
                for (int j = 0; j < h; j++)
                    if (field[i, j].Angle != 0)
                        return false;
            }
            return true;
        }

        public void RotateImage()
        {

        }

        //rectangle rotate
        /*private void Rect_MouseDown(object sender, MouseButtonEventArgs e)
        {
            double oldValue = 0; double newValue = 30;
            Rectangle current = (sender as Rectangle);
            angle += 90;
            RotateTransform rotate = new RotateTransform(angle, current.Width / 2, current.Height / 2);
            current.RenderTransform = rotate;
        }*/


    }
}
