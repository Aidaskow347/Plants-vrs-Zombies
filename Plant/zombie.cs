using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Plant
{
    internal class Zombie
    {
        public int x = 1000;
        public int y = 100;
        public int type;
        public int lane;
        public int life;

        public Zombie(int type, int lane, int life)
        {
            //zombies should always start offscreen
            this.x = 1050; 

            //randomly generate a lane and set its y value to that lane to travel down
            this.lane = lane;
            switch (lane)
            {
                case 1:
                    this.y = 100;
                    break;
                case 2:
                    this.y = 200;
                    break;
                case 3:
                    this.y = 300;
                    break;
                case 4:
                    this.y = 400;
                    break;
                case 5:
                    this.y = 500;
                    break;
            }
            //pvz has a variety of zombies, to mirror this we will set life for each zombie
            //with a variable 
            switch (type)
            {
                case 1:
                    //zombie
                    life = 10;
                    this.life = life;
                    break;
                case 2:
                    //conehead
                    life = 20;
                    break;
                case 3:
                    //buckethead
                    life = 30;
                    break;
               
            }
            this.life = life;
        }

        public void Move()
        {
            x -= 1;
        }
        public bool Collision(PeaShooter pea)
        {
            //create rectangles and check intersection
            Rectangle zombieRec = new Rectangle(x, y, S.zombieWidth / 5, S.zombieHeight / 5);
            Rectangle peaShooterRec = new Rectangle(pea.x, pea.y, S.peaWidth / 3, S.peaHeight / 3);

            if (zombieRec.IntersectsWith(peaShooterRec) && this.lane == pea.lane)
            {
                x += 16;
                return true;
            }
            return false;

        }
        public bool CollisionSun(SunFlower sun)
        {
            //create rectangles and check intersection
            Rectangle zombieRec = new Rectangle(x, y, S.zombieWidth / 5, S.zombieHeight / 5);
            Rectangle sunFlowerRec = new Rectangle(sun.x, sun.y, sun.width, sun.height);
            if (zombieRec.IntersectsWith(sunFlowerRec) && this.lane == sun.lane)
            {
                x += 16;
                return true;
            }
            return false;
        }
    }
}
