using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace WpfVersion
{
    class Energy
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Ellipse Shape{ get; set; }
        public int Speed { get; set; }

        ImageBrush image;

        public Energy()
        {
            Shape = new Ellipse();
            Shape.Height = 30;
            Shape.Width = 30;
            Speed = 3;
            X = 5;
            Y = 30;
            Shape.Margin = new System.Windows.Thickness(X, Y, 0, 0);
            Shape.Fill = Brushes.BlueViolet;
        }
        public Energy(int x, int y) : this()
        {
            X = x;
            Y = y;
            Shape.Margin = new System.Windows.Thickness(X, y, 0, 0);
        }


        public void MoveRight()
        {
            X += Speed;
            Shape.Margin = new System.Windows.Thickness(X, Y, 0, 0);
        }
        public void MoveLeft()
        {
            X -= Speed;
            Shape.Margin = new System.Windows.Thickness(X, Y, 0, 0);
        }
        public void MoveUp()
        {
            Y -= Speed;
            Shape.Margin = new System.Windows.Thickness(X, Y, 0, 0);
        }
        public void MoveDown()
        {
            Y += Speed;
            Shape.Margin = new System.Windows.Thickness(X, Y, 0, 0);
        }

        public bool MiniGameCheck(Button b)
        {
            //todo
            if (Shape.Margin.Left + Shape.Width == b.Margin.Left)
                return true;
            return false;
        }
    }
}
