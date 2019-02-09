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
using System.Windows.Media.Effects;
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
        BlurBitmapEffect myBlurEffect;
        public BitmapImage image;
        int currI;
        bool gameWon;

        public MiniGame1(BitmapImage b)
        {
            InitializeComponent();
            image = b;
            //double x = this.Height;
            //image.Height = x;
            //image.Width = Width;
            currI = 0;
            gameWon = false;
            if (image != null)
            {
                game = new MiniGame(image, 2, 2);
                game.GameCanvas = canvas;
                game.fieldFill();

                myBlurEffect = new BlurBitmapEffect();
                myBlurEffect.Radius = 50;
                game.GameCanvas.BitmapEffect = myBlurEffect;
            }
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
            Canvas.SetLeft(imWindow, x - www / 2);
            Canvas.SetTop(imWindow, y - hhh / 2);

        }

        private void generateGIF()
        {
            Image imWindow = new Image();
            var im = new BitmapImage();
            im.BeginInit();
            im.UriSource = new Uri("../../Pictures/funnyOrange.gif", UriKind.Relative);
            im.EndInit();
            ImageBehavior.SetAnimatedSource(imWindow, im);
            canvas.Children.Add(imWindow);
            double www = this.Width;
            double hhh = this.Height;
            Canvas.SetLeft(imWindow, www/4);
            Canvas.SetTop(imWindow, hhh/4);
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            game.DelCan();
            generateGIF();
            gameWon = true;

        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (gameWon)
            {
                    this.Close();
                    currI = 0;
            }
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Складіть картинку");
            myBlurEffect.Radius = 0;
            game.GameCanvas.BitmapEffect = myBlurEffect;
        }

        private void RestartButton_Click(object sender, RoutedEventArgs e)
        {
            game.Restart();
        }

        private void SettingsButton_Click(object sender, RoutedEventArgs e)
        {
            SettingsWindow setWind = new SettingsWindow();
            setWind.ShowDialog();
        }

        private void InfoButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Складіть картинку");
        }
    }
}
