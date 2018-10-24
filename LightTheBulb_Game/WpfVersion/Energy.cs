using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Shapes;

namespace WpfVersion
{
    class Energy
    {
        public int StartX { get; set; }
        public int StartY { get; set; }
        public Ellipse Shape{ get; set; }

        ImageBrush image;

        public Energy()
        {

        }

        public void Move()
        {
            //todo
        }
        bool MiniGameCheck()
        {
            //todo
            return false;
        }
    }
}
