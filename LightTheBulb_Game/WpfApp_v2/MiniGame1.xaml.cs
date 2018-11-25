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

            //Image im = new Image();
            //im.Source = b;
            //canvas.Children.Add(im);
            if (image != null)
            {
                game = new MiniGame(image, 4, 4);
                game.GameCanvas = canvas;
                game.fieldFill();
                //game.fieldFilltest();
            }
        }

        public MiniGame1(BitmapImage b) : this(){
            image = b;
            
        }
    }
}
