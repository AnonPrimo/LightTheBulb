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
using System.Windows.Navigation;
using System.Drawing;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace WpfApp_v2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Controller controller;
        DispatcherTimer timer;
        double height;
        double width;
        Rectangle rect;
        Rectangle currentRect;
        Random rand;
        int currentI;
        int currentJ;

        public MainWindow()
        {
            InitializeComponent();
            controller = new Controller();
            height = this.Height / 10;
            width = this.Width / 10;
            CreateField();
            rand = new Random();
            timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(0, 0, 0, 1, 0);
            timer.Tick += timer_Tick;
            timer.Start();
            
        }



        public bool CreateField()
        {
            for (int i = 0; i < controller.pole.GetLength(0); i++)
            {
                for (int j = 0; j < controller.pole.GetLength(1); j++)
                {
                    rect = new Rectangle
                    {
                        Stroke = Brushes.Red,
                        StrokeThickness = 0,
                        Height = height,
                        Width = width

                    };

                    if (controller.pole[i, j] == 1)
                    {
                        rect.Fill = Brushes.LightBlue;
                        Canvas.SetLeft(rect, j * width);
                        Canvas.SetTop(rect, i * height);

                        canvas.Children.Add(rect);
                    }



                    if (controller.pole[i, j] == 2)
                    {
                        rect.Fill = Brushes.DarkSeaGreen;
                        Canvas.SetLeft(rect, j * width);
                        Canvas.SetTop(rect, i * height);


                        canvas.Children.Add(rect);
                    }

                    if (controller.pole[i, j] == 3)
                    {
                        rect.Fill = Brushes.Crimson;

                        currentI = i;
                        currentJ = j;
                        currentRect = rect;

                        Canvas.SetLeft(rect, j * width);
                        Canvas.SetTop(rect, i * height);
                        canvas.Children.Add(rect);
                    }


                }
            }
            return true;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            int index = canvas.Children.IndexOf(currentRect);
            //Rectangle r = canvas.Children.index as Rectangle
            (canvas.Children[index] as Rectangle).Fill = new SolidColorBrush(Color.FromRgb((byte)rand.Next(255), (byte)rand.Next(255), (byte)rand.Next(255)));

            controller.Move();

            CreateField();


        }

        

    }
}
