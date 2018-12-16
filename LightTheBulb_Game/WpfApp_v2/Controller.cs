using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Controls;
using System.Windows;

namespace WpfApp_v2
{
    class Controller
    {
        public BitmapImage startedBitmap;
        public BitmapImage[] storyBitmaps;
        public BitmapImage[] gameBitmaps;
        public static int idRoom;

        public Controller()
        {
            storyBitmaps = new BitmapImage[5];
            gameBitmaps = new BitmapImage[5];
            startedBitmap = new BitmapImage();
            startedBitmap.BeginInit();
            startedBitmap.UriSource = new Uri(@"..\..\Pictures\sheep.jpg", UriKind.Relative);
            startedBitmap.EndInit();
            storyBitmapInit();
            gameBitmapInit();
            idRoom = 0;
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
            for (int i = 0; i < 5; i++)
            {
                gameBitmaps[i] = new BitmapImage();
                gameBitmaps[i].BeginInit();
            }
            gameBitmaps[0].UriSource = new Uri(@"..\..\Pictures\sheep1.png", UriKind.Relative);
            gameBitmaps[1].UriSource = new Uri(@"..\..\Pictures\sheep2.png", UriKind.Relative);
            gameBitmaps[2].UriSource = new Uri(@"..\..\Pictures\sheep3.png", UriKind.Relative);
            gameBitmaps[3].UriSource = new Uri(@"..\..\Pictures\sheep4.png", UriKind.Relative);
            gameBitmaps[4].UriSource = new Uri(@"..\..\Pictures\sheep5.png", UriKind.Relative);
            for (int i = 0; i < 5; ++i)
                gameBitmaps[i].EndInit();
        }

        public void NewGame(Window mw)
        {
            MiniGame1 mg = new MiniGame1(gameBitmaps[idRoom]);
            mw.Hide();
            mg.ShowDialog();
            mw.Show();
        }

        public void ContinueGame(Window mw)
        {
            MiniGame1 mg = new MiniGame1(gameBitmaps[idRoom]);
            idRoom++;
            mw.Hide();
            mg.ShowDialog();
            mw.Show();
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
