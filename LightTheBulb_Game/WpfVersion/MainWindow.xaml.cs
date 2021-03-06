﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfVersion
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Energy ball;
        BlurBitmapEffect myBlurEffect;
        public MainWindow()
        {
            InitializeComponent();
            ball = new Energy();
            canvas.Children.Add(ball.Shape);
            BitmapImage bm = new BitmapImage();
            bm.BeginInit();
            bm.UriSource = new Uri("cat.jpg", UriKind.Relative);
            bm.EndInit();
            imageForMW.Source = bm;
            myBlurEffect = new BlurBitmapEffect();
            myBlurEffect.Radius = 50;
            imageForMW.BitmapEffect = myBlurEffect;
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            
            myBlurEffect.Radius = 0;
            imageForMW.BitmapEffect = myBlurEffect;

            switch (e.Key)
            {
                case Key.Right:
                    ball.MoveRight();
                    break;
                case Key.Left:
                    ball.MoveLeft();
                    break;
                case Key.Up:
                    ball.MoveUp();
                    break;
                case Key.Down:
                    ball.MoveDown();
                    break;
                default:
                    break;
            }

             //MessageBox.Show(button.Height.ToString());


            if (ball.MiniGameCheck(button))
            {
                Books books = new Books();
                books.ShowDialog();
                ball.PutBall(button);
            }
        }

    }
}
