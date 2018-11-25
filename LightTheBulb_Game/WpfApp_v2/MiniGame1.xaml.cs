using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WpfAnimatedGif;

namespace WpfApp_v2
{
    /// <summary>
    /// Логика взаимодействия для MiniGame1.xaml
    /// </summary>
    public partial class MiniGame1 : Window
    {
        MiniGame game;
        BitmapImage image;

        public MiniGame1()
        {
            InitializeComponent();
            image = new BitmapImage(new Uri("../../cat.jpg", UriKind.Relative));
            this.Width = image.Width;
            this.Height = image.Height;

            if (image != null)
            {
                game = new MiniGame(image, 2, 2);
                game.GameCanvas = canvas;
                game.fieldFill();
                //game.fieldFilltest();
            }
            
        }

        public MiniGame1(BitmapImage b) : this(){
            image = b;
            
        }

        private void generateFirework(double x, double y)
        {
            Image imWindow = new Image();
            var im = new BitmapImage();
            im.BeginInit();
            im.UriSource = new Uri("../../Pictures/firework1.gif", UriKind.Relative);
            im.EndInit();
            ImageBehavior.SetAnimatedSource(imWindow, im);
            canvas.Children.Add(imWindow);

            double www = 400;
            double hhh = 390;
            Canvas.SetLeft(imWindow, x-www / 2);
            Canvas.SetTop(imWindow, y-hhh / 2);

        }

        private void canvas_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (game.ImageCheck())
            {
                game.StopRotate();

                Point pt = e.GetPosition((UIElement)sender);
                generateFirework(pt.X, pt.Y);
            }
        }
    }
}
