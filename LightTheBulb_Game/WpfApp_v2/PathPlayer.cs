using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp_v2
{
    class PathPlayer
    {
       public int I { get; set; }
        public int J { get; set; }
        public int Value { get; set; }


        public PathPlayer(int i, int j, int v)
        {
            Add(i, j, v);
        }

        public void Add(int i, int j, int v)
        {
            I = i;
            J = j;
            Value = v;
        }

        public void Change(int i, int j, int v)
        {
            Add(i, j, v);
        }

    }
}
