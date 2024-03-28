using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Plant
{
    internal class PlantingRegion
    {
        // determine suitable locations for plants to be planted
        public int x;
        public int y;
        public int width = 75;
        public int height = 90;
        public int lane;
        public bool valid;
        public PlantingRegion(int x, int y, int lane)
        {
            this.x = x;
            this.y = y;
            this.lane = lane;
        }
        




    }
}

