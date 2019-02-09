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
        public List<MiniGame> gameList;
        public static int idRoom;


        public Controller()
        {
            gameList = new List<MiniGame>();

            
            storyBitmaps = new BitmapImage[5];
            gameBitmaps = new BitmapImage[5];
            startedBitmap = new BitmapImage();
            startedBitmap.BeginInit();
            startedBitmap.UriSource = new Uri(@"..\..\Pictures\sheep.jpg", UriKind.Relative);
            startedBitmap.EndInit();
            //storyBitmapInit();
            //gameBitmapInit();
            idRoom = 0;
        }

        private void CreateImageGame()
        {
            Controllers.CreateImage createImage = new Controllers.CreateImage();
            gameList.Add(createImage);
        }

        //public void storyBitmapInit()
        //{
        //    for (int i = 0; i < 5; i++)
        //    {
        //        storyBitmaps[i] = new BitmapImage();
        //        storyBitmaps[i].BeginInit();
        //    }
        //    storyBitmaps[0].UriSource = new Uri(@"..\..\Pictures\sheep1.png", UriKind.Relative);
        //    storyBitmaps[1].UriSource = new Uri(@"..\..\Pictures\sheep2.png", UriKind.Relative);
        //    storyBitmaps[2].UriSource = new Uri(@"..\..\Pictures\sheep3.png", UriKind.Relative);
        //    storyBitmaps[3].UriSource = new Uri(@"..\..\Pictures\sheep4.png", UriKind.Relative);
        //    storyBitmaps[4].UriSource = new Uri(@"..\..\Pictures\sheep5.png", UriKind.Relative);
        //    for(int i = 0; i < 5; ++i)
        //        storyBitmaps[i].EndInit();

        //}

        //public void gameBitmapInit()
        //{
        //    for (int i = 0; i < 5; i++)
        //    {
        //        gameBitmaps[i] = new BitmapImage();
        //        gameBitmaps[i].BeginInit();
        //    }
        //    gameBitmaps[0].UriSource = new Uri(@"..\..\Pictures\sheep1.png", UriKind.Relative);
        //    gameBitmaps[1].UriSource = new Uri(@"..\..\Pictures\sheep2.png", UriKind.Relative);
        //    gameBitmaps[2].UriSource = new Uri(@"..\..\Pictures\sheep3.png", UriKind.Relative);
        //    gameBitmaps[3].UriSource = new Uri(@"..\..\Pictures\sheep4.png", UriKind.Relative);
        //    gameBitmaps[4].UriSource = new Uri(@"..\..\Pictures\sheep5.png", UriKind.Relative);
        //    for (int i = 0; i < 5; ++i)
        //        gameBitmaps[i].EndInit();
        //}

        public void NewGame(MainWindow mw)
        {
            idRoom = 0;
            MiniGame1 mg = new MiniGame1(gameBitmaps[idRoom]);
            mw.Hide();
            mg.ShowDialog();
            ++idRoom;
            ContinueGame(mw);
            mw.Show();
        }

        public void ContinueGame(MainWindow mw)
        {
            while (idRoom < 5)
            {
                MiniGame1 mg = new MiniGame1(gameBitmaps[idRoom]);
                mw.Hide();
                mg.ShowDialog();
                ++idRoom;
                
            } 

            MessageBox.Show("You win!");

            mw.Show();

        }

        public void ContinueGame(MiniGame1 mg)
        {
            mg.image = gameBitmaps[idRoom];
            idRoom++;
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
