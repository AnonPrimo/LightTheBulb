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
        private int idRoom;

        public Controller()
        {
            storyBitmaps = new BitmapImage[5];
            gameBitmaps = new BitmapImage[1];
            startedBitmap = new BitmapImage();
            startedBitmap.BeginInit();
            startedBitmap.UriSource = new Uri(@"..\..\Pictures\sheep.jpg", UriKind.Relative);
            startedBitmap.EndInit();
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
            gameBitmaps[0].UriSource = new Uri(@"..\..\cat.jpg", UriKind.Relative);
            gameBitmaps[0].EndInit();
        }

        public void NewGame(MainWindow mw)
        {
            idRoom = 0;
            MiniGame1 mg = new MiniGame1(gameBitmaps[idRoom]);
            mw.Hide();
            mg.ShowDialog();
            mw.Show();
        }

        public void ContinueGame(MainWindow mw)
        {
            idRoom = 0;
            MiniGame1 mg = new MiniGame1(gameBitmaps[idRoom]);
            mw.Hide();
            mg.ShowDialog();
            mw.Show();
            //mw.button_NG.Visibility = Visibility.Hidden;
            //mw.button_ContinueG.Visibility = Visibility.Hidden;
            //mw.button_Exit.Visibility = Visibility.Hidden;
            //mw.imageForMW.Source = gameBitmaps[idRoom];
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
