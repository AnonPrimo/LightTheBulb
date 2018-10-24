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
using System.Windows.Shapes;

namespace WpfVersion
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Energy ball;

        public MainWindow()
        {
            InitializeComponent();
            ball = new Energy();
            canvas.Children.Add(ball.Shape);
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.Key) {
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
        }
    }
}
