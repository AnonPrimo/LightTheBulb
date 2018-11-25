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
        public System.Windows.Controls.Canvas GameCanvas { get; set; }
        BitmapImage image;
        RectangleImage[,] field;
        int w, h;

        public MiniGame(BitmapImage im, int x, int y)
        {
            w = x;
            h = y;
            image = im;
        }

        public void fieldFill()
        {
            int cw, ch;
            cw = image.PixelWidth / w;
            ch = image.PixelHeight / h;

            field = new RectangleImage[w, h];
            for (int i = 0; i < w; i++)
            {
                for (int j = 0; j < h; j++)
                {
                    field[i, j] = new RectangleImage(new CroppedBitmap(image, new System.Windows.Int32Rect(j * cw, i * ch, cw, ch)));
                    GameCanvas.Children.Add(field[i, j].Rect);
                    System.Windows.Controls.Canvas.SetLeft(field[i, j].Rect, j * cw);
                    System.Windows.Controls.Canvas.SetTop(field[i, j].Rect, i * ch);
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
