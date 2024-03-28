using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Plant
{
    internal class Sun
    {
        public int x;
        public int y = 100;
        public int width = S.sunWidth/4;
        public int height = S.sunHeight/4;

        public Sun(int x, int y)
        {
            this.x = x;
            this.y = y;
           
        }

        public void Move()
        {
            y++;
        }
    }
}
