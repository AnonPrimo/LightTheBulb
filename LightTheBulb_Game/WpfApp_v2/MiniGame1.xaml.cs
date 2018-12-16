using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
        double x, y;
        Controller controller;
        int currI;
        bool btnIspr;
        bool gameWon;

        public MiniGame1(BitmapImage b)
        {
            controller = new Controller();
            InitializeComponent();
            button1.Visibility = Visibility.Hidden;
            image = b; //new BitmapImage(new Uri("../../cat.jpg", UriKind.Relative));
            x = this.Width;
            y = this.Height;
            this.Width = image.Width;
            this.Height = image.Height;
            btnIspr = false;
            currI = 0;
            gameWon = false;
            if (image != null)
            {
                game = new MiniGame(image, 2, 2);
                game.GameCanvas = canvas;
                game.fieldFill();
                //game.fieldFilltest();
            }
        }

        //public MiniGame1() : this(){
        //    image = b; }

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
            Canvas.SetLeft(imWindow, x - www / 2);
            Canvas.SetTop(imWindow, y - hhh / 2);

        }

        private void generateGIF(/*double x, double y*/)
        {
            Image imWindow = new Image();
            var im = new BitmapImage();
            im.BeginInit();
            im.UriSource = new Uri("../../Pictures/funnyOrange.gif", UriKind.Relative);
            im.EndInit();
            ImageBehavior.SetAnimatedSource(imWindow, im);
            canvas.Children.Add(imWindow);
            }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            game.DelCan();
            generateGIF();
            
            btnIspr = true;
            gameWon = true;

        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (gameWon)
            {
                canvas.Children.Clear();
                if (btnIspr && currI < 5)
                {
                    imageForMG.Source = controller.storyBitmaps[currI];
                    currI++;
                }
                else
                {
                    if (currI == 5)
                    {
                        controller.ContinueGame(this);
                        this.Close();
                    }
                    currI = 0;
                    btnIspr = false;
                }
            }
        }

        private void canvas_MouseDown(object sender, MouseButtonEventArgs e)
        {

            if (game.ImageCheck())
            {
                game.StopRotate();

                //this.Width = x;
                //this.Height = y;

                Point pt = e.GetPosition((UIElement)sender);
                generateFirework(pt.X, pt.Y);

                button1.Visibility = Visibility.Visible;
            }
        }

    }
}
