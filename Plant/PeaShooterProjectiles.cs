using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Plant
{
    internal class PeaShooterProjectiles
    {
        public int x;
        public int y;
        public int width = 30;
        public int height = 30;
        public PeaShooterProjectiles(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void MoveProjectiles()
        {
            this.x += 10;
            
        }
        // check for collision with rectangles
        public bool Collision(Zombie zombie)
        {
            Rectangle projectileRec = new Rectangle(x, y, S.peaBallWidth/5, S.peaBallHeight/5);
            Rectangle zombieRec = new Rectangle(zombie.x, zombie.y, S.zombieWidth/5,S.zombieHeight/5);

            if (projectileRec.IntersectsWith(zombieRec))
            { 
                return true;
            }
            return false;

        }
    }
}
