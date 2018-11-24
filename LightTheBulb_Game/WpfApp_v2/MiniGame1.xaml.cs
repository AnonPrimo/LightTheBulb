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

        public MiniGame1()
        {
            InitializeComponent();
            BitmapImage b = new BitmapImage(new Uri("../../cat.jpg", UriKind.Relative));
            game = new MiniGame(b, 4,4);
        }
    }
}
