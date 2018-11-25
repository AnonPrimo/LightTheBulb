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

        public BitmapImage[] storyBitmaps;
        public BitmapImage[] gameBitmaps;
        private int idRoom;


        public Controller()
        {
            storyBitmaps = new BitmapImage[5];
            gameBitmaps = new BitmapImage[1];
            storyBitmapInit();
            gameBitmapInit();
        }

        public void storyBitmapInit()
        {
            for (int i = 0; i < 5; i++)
            {
                storyBitmaps[i] = new BitmapImage();
            storyBitmaps[i].BeginInit();
            }
            storyBitmaps[0].UriSource = new Uri(@"..\..\Pictures\sheep1.png", UriKind.Relative);
            storyBitmaps[1].UriSource = new Uri(@"..\..\Pictures\sheep2.png", UriKind.Relative);
            storyBitmaps[2].UriSource = new Uri(@"..\..\Pictures\sheep3.png", UriKind.Relative);
            storyBitmaps[3].UriSource = new Uri(@"..\..\Pictures\sheep4.png", UriKind.Relative);
            storyBitmaps[4].UriSource = new Uri(@"..\..\Pictures\sheep5.png", UriKind.Relative);
            for(int i = 0; i < 5; ++i)
                storyBitmaps[i].EndInit();

        }

        public void gameBitmapInit()
        {
            gameBitmaps[0] = new BitmapImage();
            gameBitmaps[0].BeginInit();
            gameBitmaps[0].UriSource = new Uri(@"..\..\Pictures\sheep.png", UriKind.Relative);
            gameBitmaps[0].EndInit();
        }

        public void NewGame()
        {
            idRoom = 0;

        }

        public void ContinueGame()
        {
            idRoom = 0;
            NewMiniGame();
        }

        public void NewMiniGame()
        {
            MiniGame mg = new MiniGame(gameBitmaps[idRoom], 4, 4);
            mg.fieldFill();
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
