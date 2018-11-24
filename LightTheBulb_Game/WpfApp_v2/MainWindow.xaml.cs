﻿using System;
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
using System.Windows.Navigation;
using System.Drawing;
using System.Windows.Shapes;
using System.Windows.Threading;
using static System.Net.Mime.MediaTypeNames;
using System.Threading;
using System.Media;

namespace WpfApp_v2
{
    public partial class MainWindow : Window
    {
        Controller controller;
        DispatcherTimer timer;
        int currI;
        bool btnIspr;
        MediaPlayer mediaPlayer = new MediaPlayer();

        public MainWindow()
        {
            InitializeComponent();

            controller = new Controller();
            timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(0, 0, 0, 1, 0);
            timer.Tick += timer_Tick;
            currI = 0;
            Rect();
            btnIspr = false;

            mediaPlayer.Open(new Uri(@"..\..\papa-roach_-_forever.mp3", UriKind.Relative));
            mediaPlayer.Play();
        }
        
        private void timer_Tick(object sender, EventArgs e)
        {
            
           
        }

        private void button_NG_Click(object sender, RoutedEventArgs e)
        {
            button_NG.Visibility = Visibility.Hidden;
            button_ContinueG.Visibility = Visibility.Hidden;
            button_Exit.Visibility = Visibility.Hidden;

            controller.NewGame();

            
            btnIspr = true;
            Thread.Sleep(500);
            timer.Start();

        }

        private void button_ContinueG_Click(object sender, RoutedEventArgs e)
        {
            controller.ContinueGame();
        }


        void Rect()
        {

        }

        private void button_Exit_Click(object sender, RoutedEventArgs e)
        {
            //this.Close();
            Environment.Exit(1);
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
          
            imageForMW.Source = controller.allBitmaps[currI];
            if (btnIspr)
            if (currI < 4)
                currI++;
        }
    }
}
