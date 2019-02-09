using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp_v2
{
    public abstract class MiniGame
    {
        public virtual void FillCanvas() { }
        public virtual string GetRules(){
            return "Game";
        }
        public virtual bool CheckGame()
        {
            return false;
        }
        public virtual void Restart() { }

    }
}
