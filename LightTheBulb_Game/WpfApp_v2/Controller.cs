using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp_v2
{
    class Controller
    {
        // List<PathPlayer> pathPlayer;

        // public int[,] pole = {
        // {0,0,3,0,0,0,0,0,0,0},
        // {0,0,1,0,0,0,0,0,0,0},
        // {0,0,1,1,0,0,0,0,0,0},
        // {0,0,0,1,1,0,0,0,0,0},
        // {0,0,0,0,1,0,0,0,0,0},
        // {0,0,0,0,1,0,0,0,0,0},
        // {0,0,0,0,1,1,0,0,0,0},
        // {0,0,0,0,0,1,1,1,0,0},
        // {0,0,0,0,0,0,0,1,0,0},
        // {0,0,0,0,0,0,0,1,1,1}
        // };
        // public Controller()
        // {
        //     pathPlayer = new List<PathPlayer>();
        //     for (int i = 0; i < pole.GetLength(0); i++)
        //     {
        //         for (int j = 0; j < pole.GetLength(1); j++)
        //         {
        //             if (pole[i, j] != 0)
        //             {
        //                 pathPlayer.Add(new PathPlayer(i, j, pole[i, j]));
        //             }
        //         }
        //     }
        // }
        //public bool Move()
        // {

        //     foreach (var item in pathPlayer)
        //     {
        //         if (item.Value == 3)
        //         {
        //             pole[item.I, item.J] = 2;
        //             continue;
        //         }
        //         if (item.Value == 1)
        //         {
        //             pole[item.I, item.J] = 3;
        //             return true; 
        //         }
        //     }
        //     return false;
        // }

        public BitmapImage[] allBitmaps;

        public Controller()
        {
            allBitmaps = new BitmapImage[5];
            BitmapInit();
        }

        public void BitmapInit()
        {
            for (int i = 0; i < 5; i++)
            {
                allBitmaps[i] = new BitmapImage();
            allBitmaps[i].BeginInit();
            }
            allBitmaps[0].UriSource = new Uri(@"..\..\Pictures\sheep1.png", UriKind.Relative);
            allBitmaps[1].UriSource = new Uri(@"..\..\Pictures\sheep2.png", UriKind.Relative);
            allBitmaps[2].UriSource = new Uri(@"..\..\Pictures\sheep3.png", UriKind.Relative);
            allBitmaps[3].UriSource = new Uri(@"..\..\Pictures\sheep4.png", UriKind.Relative);
            allBitmaps[4].UriSource = new Uri(@"..\..\Pictures\sheep5.png", UriKind.Relative);
            for(int i = 0; i < 5; ++i)
                allBitmaps[i].EndInit();

        }

        public void NewGame()
        {
            
        }

        public void ContinueGame()
        {

        }

        public void NewMiniGame()
        {

        }

        public void SaveGame()
        {

        }

        public bool CheckMG()
        {
            return false;
        }

    }
}
