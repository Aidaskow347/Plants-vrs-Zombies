using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plant
{
    internal class SunFlower
    {
        public int x;
        public int y;
        public int lane;
        public int life;
        public int width = Properties.Resources.sunFlower.Width/7;
        public int height = Properties.Resources.sunFlower.Height/7;
        public SunFlower(int x, int lane, int life) 
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
