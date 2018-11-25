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


        //test
        public void fieldFilltest()
        {
            int cw, ch;
            cw = (int)(image.PixelWidth / w);
            ch = (int)(image.PixelHeight / h);
            System.Diagnostics.Debug.WriteLine("w = {0}, h = {1}",cw,ch);

            field = new RectangleImage[w, h];
            field[0, 0] = new RectangleImage(new CroppedBitmap(image, new System.Windows.Int32Rect(0, 0, cw*2,ch*4)));

            GameCanvas.Children.Add(field[0, 0].Rect);
            System.Windows.Controls.Canvas.SetLeft(field[0, 0].Rect, image.Width/w*0);
            System.Windows.Controls.Canvas.SetTop(field[0, 0].Rect, image.Height/h*0);

            field[0, 1] = new RectangleImage(new CroppedBitmap(image, new System.Windows.Int32Rect(cw * 2, 0, cw * 2, ch * 4)));

            GameCanvas.Children.Add(field[0, 1].Rect);
            System.Windows.Controls.Canvas.SetLeft(field[0, 1].Rect, image.Width / w * 2);
            System.Windows.Controls.Canvas.SetTop(field[0, 1].Rect, image.Height / h * 0);
        }


        public void fieldFill()
        {
            int cw, ch;
            cw = (int)(image.PixelWidth / w);
            ch = (int)(image.PixelHeight / h);

            field = new RectangleImage[w, h];
            for (int i = 0; i < w; i++)
            {
                for (int j = 0; j < h; j++)
                {
                    field[i, j] = new RectangleImage(new CroppedBitmap(image, new System.Windows.Int32Rect(j * cw, i * ch, cw, ch)));
                    GameCanvas.Children.Add(field[i, j].Rect);
                    //System.Windows.Controls.Canvas.SetLeft(field[i, j].Rect, j * cw);
                    //System.Windows.Controls.Canvas.SetTop(field[i, j].Rect, i * ch);

                    System.Windows.Controls.Canvas.SetLeft(field[i, j].Rect, j * image.Width/w);
                    System.Windows.Controls.Canvas.SetTop(field[i, j].Rect, i * image.Height/h);
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
