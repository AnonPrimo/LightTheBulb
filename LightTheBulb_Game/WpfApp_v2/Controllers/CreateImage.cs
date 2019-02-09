using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace WpfApp_v2.Controllers
{
    class CreateImage : MiniGame
    {
        public System.Windows.Controls.Canvas GameCanvas { get; set; }
        BitmapImage image;
        RectangleImage[,] field;
        int w, h;

        bool IsPassed;

        public CreateImage()
        {
            IsPassed = false;
            w = 4;
            h = 4;

            //todo get image
            image = new BitmapImage(new Uri(@"..\..\Pictures\sheep.jpg", UriKind.Relative));
        }

        //test
        public void fieldFilltest()
        {
            int cw, ch, cwCanvas, chCanvas;
            cw = (int)(image.PixelWidth / w);
            ch = (int)(image.PixelHeight / h);
            cwCanvas = (int)(image.Width / w);
            chCanvas = (int)(image.Height / h);

            System.Diagnostics.Debug.WriteLine("w = {0}, h = {1}", cw, ch);

            field = new RectangleImage[w, h];

            field[0, 0] = new RectangleImage(new CroppedBitmap(image, new System.Windows.Int32Rect(0, 0, cw * 2, ch * 2)));

            GameCanvas.Children.Add(field[0, 0].Rect);
            System.Windows.Controls.Canvas.SetLeft(field[0, 0].Rect, 0);
            System.Windows.Controls.Canvas.SetTop(field[0, 0].Rect, 0);

            field[0, 1] = new RectangleImage(new CroppedBitmap(image, new System.Windows.Int32Rect(cw * 2, ch * 2, cw * 2, ch * 2)));

            GameCanvas.Children.Add(field[0, 1].Rect);
            System.Windows.Controls.Canvas.SetLeft(field[0, 1].Rect, cwCanvas * 2);
            System.Windows.Controls.Canvas.SetTop(field[0, 1].Rect, chCanvas * 2);

            //GameCanvas.Children.Add(field[0, 0].Rect);
            //System.Windows.Controls.Canvas.SetLeft(field[0, 0].Rect, image.Width/w*0);
            //System.Windows.Controls.Canvas.SetTop(field[0, 0].Rect, image.Height/h*0);

            //field[0, 1] = new RectangleImage(new CroppedBitmap(image, new System.Windows.Int32Rect(cw * 2, 0, cw * 2, ch * 4)));

            //GameCanvas.Children.Add(field[0, 1].Rect);
            //System.Windows.Controls.Canvas.SetLeft(field[0, 1].Rect, image.Width / w * 2);
            //System.Windows.Controls.Canvas.SetTop(field[0, 1].Rect, image.Height / h * 0);
        }


        public override void FillCanvas()
        {
            int cw, ch, cwCanvas, chCanvas;
            cw = (int)(image.PixelWidth / w);
            ch = (int)(image.PixelHeight / h);

            cwCanvas = (int)(image.Width / w) + 1;
            chCanvas = (int)(image.Height / h) + 1;

            field = new RectangleImage[w, h];
            for (int i = 0; i < w; i++)
            {
                for (int j = 0; j < h; j++)
                {
                    field[i, j] = new RectangleImage(new CroppedBitmap(image, new System.Windows.Int32Rect(j * cw, i * ch, cw, ch)));
                    GameCanvas.Children.Add(field[i, j].Rect);

                    field[i, j].Rotate(new Random((int)DateTime.Now.Ticks).Next(0, 4) * 90);

                    System.Windows.Controls.Canvas.SetLeft(field[i, j].Rect, j * cwCanvas);
                    System.Windows.Controls.Canvas.SetTop(field[i, j].Rect, i * chCanvas);
                }
            }
        }

        public bool ImageCheck()
        {
            for (int i = 0; i < w; i++)
            {
                for (int j = 0; j < h; j++)
                    if (field[i, j].Angle != 0)
                        return false;
            }
            return true;
        }

        public bool StopRotate()
        {
            for (int i = 0; i < w; i++)
            {
                for (int j = 0; j < h; j++)
                    field[i, j].DisableRect();
            }
            return true;
        }

        public void DelCan()
        {
            GameCanvas.Children.Clear();
        }

        public override void Restart()
        {
            DelCan();
            FillCanvas();
        }

        public override string GetRules()
        {
            return "Складіть картинку, повертаючи елементи на 90 градусів! =)";
        }

        public override bool CheckGame()
        {
            if (IsPassed)
                return true;
            return false;
        }

    }
}
