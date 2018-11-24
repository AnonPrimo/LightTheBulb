using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp_v2
{
    public class MiniGame
    {
        BitmapImage image;
        Rectangle[,] field; 

        public MiniGame(BitmapImage im)
        {
            image = im;
        }

        private void imageCut()
        {
            int w = 4, h = 4;
            field = new Rectangle[w, h];
            for (int i = 0; i < w; i++)
            {
                for(int j = 0; j < h; j++)
                {

                }
            }
        }

    }
}
