using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plant
{
    internal class PeaShooter
    {
        public int x = 100;
        public int y;
        public int width = 75;
        public int height = 75;
        public int lane;
        public int life;
        
        public PeaShooter (int x, int lane,int life)
        {
            this.life = 5;
            this.x = x;
            this.lane = lane;
            switch (lane)
            {
                case 1:
                    this.y = 150;
                    break;
                case 2:
                    this.y = 250;
                    break;
                case 3:
                    this.y = 350;
                    break;
                case 4:
                    this.y = 450;
                    break;
                case 5:
                    this.y = 550;
                    break;
            }
        
        }
    }
}
