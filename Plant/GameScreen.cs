using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

/**
 * pvz GameScreen, if a zombie makes it to the left of the screen, you lose defend yourself with plants and survive for as long as you can
 */

/**
 * bugs to fix in the future
 * --------------------------
 * Game is severely unbalanced and unpredictable, mostly depends on how fast the game timer is running
 * 
 * Drawings off mode is actually more like a hard mode with how fast the game runs compared to drawings on
 * 
 * if two zombies eat plants at the same time, only one zombie will actually be eating a plant
 * 
 * have not implemented a way to place back plants after they have been eaten
 * 
 * needs more plants (too scared to implement more because of the speed of game timer
 * 
 */
namespace Plant
{
    // I am unsure why but my class GameScreen got renamed to S, because I am too scared to change it back, I have not changed it
    public partial class S : UserControl
    {
        #region Lists and Arrays

        // list for zombies 
        List<Zombie> zombieList = new List<Zombie>();
        //list to determine where we can place a plant
        List<PlantingRegion> pRegionList = new List<PlantingRegion>();

        // list for sun values
        List<Sun> sunList = new List<Sun>();

        // lists for different plant types
        List<PeaShooter> pShootList = new List<PeaShooter>();
        List<SunFlower> sunFlowerList = new List<SunFlower>();

        // lists for different plant types
        List<PeaShooterProjectiles> pShootProjectileList = new List<PeaShooterProjectiles>();

        #endregion

        #region variables

        // for planting region (x,y, lane)

        int xPR = 175;
        int yPR = 50;
        int lanePR = 0;
    
        // for PeaShooterProjectiles y value
        int yPSP = 0;

        // brushes and pens
        Pen whitePen = new Pen(Color.White);
        Brush zombieBrush = new SolidBrush(Color.DarkOliveGreen);
        Brush zombie2Brush = new SolidBrush(Color.ForestGreen);
        Brush zombie3Brush = new SolidBrush(Color.LimeGreen);
        Brush sunBrush = new SolidBrush(Color.Goldenrod);
        Brush sunFlowerBrush = new SolidBrush(Color.DarkGoldenrod);
        Brush peaShooterBrush = new SolidBrush(Color.LawnGreen);

        //random
        Random r = new Random();

        //stopwatch
        public static Stopwatch survivalTimer = new Stopwatch();

        // sound player

        SoundPlayer sound = new SoundPlayer(Properties.Resources.GrassWalk);

        // plant bools

        public static bool peaBool = false;
        public static bool sunFlowerBool = false;
        public static bool drawImage = true;

        //value tracker
        int sunValue = 50;

        //mouse tracking
        PointF mousePosition;
        Rectangle cursor = new Rectangle(0, 0, 1, 1);

        //stat tracking variables

        public static int plantsPlaced, sunCollected, sunSpent, zombiesKilled;
        
        #endregion

        #region image variables
        // use these variables to replace using image properties which takes a lot of time and is hard to easily read

        public static int zombieWidth = Properties.Resources.zombie1.Width;
        public static int zombieHeight = Properties.Resources.zombie1.Height;

        public static int peaWidth = Properties.Resources.peaShooter.Width;
        public static int peaHeight = Properties.Resources.peaShooter.Height;

        public static int peaBallWidth = Properties.Resources.peaProjectile.Width;
        public static int peaBallHeight = Properties.Resources.peaProjectile.Height;

        public static int sunWidth = Properties.Resources.Sun.Width;
        public static int sunHeight = Properties.Resources.Sun.Height;

        public static int sunFlowerWidth = Properties.Resources.sunFlower.Width;
        public static int sunFlowerHeight = Properties.Resources.sunFlower.Height;


        #endregion

        public S()
        {
            InitializeComponent();
            InitializeGame();
        }

        public void InitializeGame()
        {


            Width = this.Width;
            // find a way to make a region grid for suitable plants positions
            // 5 lanes 9 plant spots
            /*
            1 2 3 4 5 6 7 8 9
            2 x x x x x x x x
            3 x x x x x x x x
            4 x x x x x x x x
            5 x x x x x x x x
            */
            for (int i = 0; i < 5; i++)
            {
                // increase the y value of each region
                yPR += 100;
                lanePR++;
                for (int l = 0; l < 9; l++)
                {
                    xPR += 80;
                    PlantingRegion pRegion = new PlantingRegion(xPR, yPR, lanePR);
                    pRegionList.Add(pRegion);
                }
                //reset the x values of the boxes
                xPR = 175;

            }
            //start survivalTimer
            survivalTimer.Start();
            sound.Play();
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {


            // move zombie unless faced with a plant
            foreach (Zombie z in zombieList)
            {
                z.Move();
            }

            // move peashooter projectiles
            foreach (PeaShooterProjectiles p in pShootProjectileList)
            {
                p.MoveProjectiles();
            }
            // move suns 
            foreach (Sun s in sunList)
            {
                s.Move();

                if (s.y > 600)
                {
                    sunList.Remove(s);
                    break;
                }
            }

            //check if a peashooters projectiles collide with an zombie

            foreach (PeaShooterProjectiles p in pShootProjectileList)
            {
                for (int i = 0; i < zombieList.Count; i++)
                {
                    if (p.Collision(zombieList[i]))
                    {
                        //remove a life, delete zombie at 0 life and add stat tracker variable
                        zombieList[i].life--;
                        if (zombieList[i].life < 1)
                        {
                            zombiesKilled++;
                            zombieList.Remove(zombieList[i]);
                        }

                        // remove projectile
                        pShootProjectileList.Remove(p);
                        return;
                    }
                }

            }
            // remove any offscreen projectiles to save resources
            foreach (PeaShooterProjectiles p in pShootProjectileList)
            {
                if (p.x > 1200)
                {
                    pShootProjectileList.Remove(p);
                    break;
                }
            }


            // check if the cursor ever hovers over a sun
            for (int i = 0; i < sunList.Count; i++)
            {
                if (cursor.IntersectsWith(new Rectangle(sunList[i].x, sunList[i].y, sunList[i].width, sunList[i].height)))
                {
                    // if cursor intersects with sun add money and display transaction
                    sunCollected += 25;
                    sunValue += 25;
                    displayLabel.ForeColor = Color.Goldenrod;
                    displayLabel.Text = "Sun Collected +25";
                    sunList.RemoveAt(i);
                }
            }
            //show how much money exists in the bank
            moneyLabel.Text = "Sun Value: " + sunValue.ToString();

            // determine game over
            foreach (Zombie z in zombieList)
            {
                if (z.x < 0)
                {
                    #region New Game Resets
                    // stop game timer
                    gameTimer.Stop();

                    sound.Stop();
                     sunValue = 50;
                    plantsPlaced = 0;
                    sunCollected = 0;
                    sunSpent = 0;
                    zombiesKilled = 0;
                    survivalTimer.Reset();
                    pShootList.Clear();
                    sunFlowerList.Clear();
                    zombieList.Clear();
                    sunList.Clear();
                    pRegionList.Clear();
                    #endregion

                    sunValue = 25;

                    Form1.ChangeScreen(this, new StatScreen());
                }
            }
            // display time survived
            timeLabel.Text = "Time Survived: " + survivalTimer.Elapsed.ToString(@"mm\:ss");



            Refresh();
        }

        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {

            foreach (PlantingRegion p in pRegionList)
            {

                if (cursor.IntersectsWith(new Rectangle(p.x, p.y, p.width, p.height)))
                {
                    e.Graphics.DrawRectangle(whitePen, p.x, p.y, p.width, p.height);
                }
        
            }

            if (drawImage == true)
            {

                #region plants
                // region to sort code
                foreach (PeaShooter p in pShootList)
                {
                    e.Graphics.DrawImage(Properties.Resources.peaShooter, p.x, p.y, peaWidth / 3, peaWidth / 3);
                }
                foreach (SunFlower s in sunFlowerList)
                {
                    e.Graphics.DrawImage(Properties.Resources.sunFlower, s.x, s.y, s.width, s.height);
                }

                #endregion

                //draw each zombie in zombieList
                foreach (Zombie z in zombieList)
                {
                    // display a different image depending on the zombie type to help guide the player
                    if (z.life > 20)
                    {
                        e.Graphics.DrawImage(Properties.Resources.zombie3, z.x, z.y, zombieWidth / 5, zombieHeight / 5);
                    }
                    else if (z.life > 10)
                    {
                        e.Graphics.DrawImage(Properties.Resources.zombie2, z.x, z.y, zombieWidth / 5, zombieHeight / 5);
                    }
                    else
                    {
                        e.Graphics.DrawImage(Properties.Resources.zombie1, z.x, z.y, zombieWidth / 5, zombieHeight / 5);
                    }
                }

                foreach (PeaShooterProjectiles p in pShootProjectileList)
                {
                    e.Graphics.DrawImage(Properties.Resources.peaProjectile, p.x, p.y, peaBallWidth / 5, peaBallHeight / 5);
                }

                foreach (Sun s in sunList)
                {
                    e.Graphics.DrawImage(Properties.Resources.Sun, s.x, s.y, s.width, s.height);
                }


            }
            // ignore drawing images for each drawing if a bool is active (saves program speed)
            else
            {

                #region plants
                // region to sort code
                foreach (PeaShooter p in pShootList)
                {
                    e.Graphics.FillRectangle(peaShooterBrush, p.x, p.y, peaWidth / 3, peaWidth / 3);
                }
                foreach (SunFlower s in sunFlowerList)
                {
                    e.Graphics.FillRectangle(sunFlowerBrush, s.x, s.y, s.width, s.height);
                }

                #endregion

                foreach (Zombie z in zombieList)
                {
                    // display a different image depending on the zombie type to help guide the player
                    if (z.life > 20)
                    {
                        e.Graphics.FillRectangle(zombie3Brush, z.x, z.y, zombieWidth / 5, zombieHeight / 5);
                    }
                    else if (z.life > 10)
                    {
                        e.Graphics.FillRectangle(zombie2Brush, z.x, z.y, zombieWidth / 5, zombieHeight / 5);
                    }
                    else
                    {
                        e.Graphics.FillRectangle(zombieBrush, z.x, z.y, zombieWidth / 5, zombieHeight / 5);
                    }
                }

                foreach (PeaShooterProjectiles p in pShootProjectileList)
                {
                    e.Graphics.FillRectangle(peaShooterBrush, p.x, p.y, peaBallWidth / 5, peaBallHeight / 5);
                }

                foreach (Sun s in sunList)
                {
                    e.Graphics.FillRectangle(sunBrush, s.x, s.y, s.width, s.height);
                }
            }

        }

        //plants slots
        #region Plants Selection

        // disable all plant bools

        public void plantBools()
        {
            // disable all exclusive bools for next selection to be accurate
            
            peaBool = false;
            sunFlowerBool = false;

            //reset slot color

            SlotBox1.BackColor = Color.FromArgb(172, 98, 15);
            SlotBox2.BackColor = Color.FromArgb(172, 98, 15);
        }

        // check if a plant has been selected to be planted
        private void slotBox1_Click(object sender, EventArgs e)
        {
            // make peashooter be selected for next plant and disable other bools
            // also change color of current selected slot
            plantBools();
            SlotBox1.BackColor = Color.Goldenrod;
            peaBool = true;
        }
        private void SlotBox2_Click(object sender, EventArgs e)
        {
            //sunflower 
            plantBools();
            SlotBox2.BackColor = Color.Goldenrod;
            sunFlowerBool = true;
        }

        #endregion

        #region Slot Boxes

        private void GameScreen_Click(object sender, EventArgs e)
        {
            //check if a planting region has been clicked by the player

            for (int i = 0; i < pRegionList.Count; i++)
            {
                if (cursor.IntersectsWith(new Rectangle(pRegionList[i].x, pRegionList[i].y, pRegionList[i].width, pRegionList[i].height)))
                {
                    //if specific plant is selected and funds available, spawn plant on that slot

                    if (peaBool == true && sunValue >= 100)
                    {
                        //remove sun value and add it to stat variable
                        sunSpent += 100;
                        sunValue -= 100;
                        //create a peashooter on the selected spot
                        PeaShooter pea = new PeaShooter(pRegionList[i].x, pRegionList[i].lane, 5);
                        pShootList.Add(pea);

                        plantingMethod();
                        // display what transaction occurred and add to stat tracker

                        displayLabel.Text = "Purchased: Peashooter";
                        plantsPlaced++;
                        pRegionList.Remove(pRegionList[i]);
                        break;

                    }
                    else if (sunFlowerBool == true && sunValue >= 50)
                    {
                        //remove sun value and add it to stat variable
                        sunSpent += 50;
                        sunValue -= 50;
                        //create a sunflower on the selected spot

                        SunFlower seed = new SunFlower(pRegionList[i].x, pRegionList[i].lane, 5);
                        sunFlowerList.Add(seed);

                        plantingMethod();
                        // display what transaction occurred and add to stat tracker

                        displayLabel.Text = "Purchased: SunFlower";
                        plantsPlaced++;
                        pRegionList.Remove(pRegionList[i]);
                        break;

                    }
                    else if (peaBool == false || sunFlowerBool == false)
                    {
                        //display error message if no bool selected
                        displayLabel.ForeColor = Color.DarkSalmon;
                        displayLabel.Text = "Select a Plant before Placing";
                    }
                    else
                    {
                        //display error message when no available funds
                        displayLabel.ForeColor = Color.DarkSalmon;
                        displayLabel.Text = "Insufficient Funds";
                    }

                }
            }
        }
        public void plantingMethod()
        {
            // show current action
            displayLabel.ForeColor = Color.LightGreen;

            //reset box selected
            plantBools();



        }

        #endregion

        //create a rectangle to track mouse position
        private void GameScreen_MouseMove(object sender, MouseEventArgs e)
        {
            mousePosition = this.PointToClient(Cursor.Position);
            cursor = new Rectangle(Convert.ToInt16(mousePosition.X), Convert.ToInt16(mousePosition.Y), 1, 1);
        }

        private void shootTimer_Tick(object sender, EventArgs e)
        {
            foreach (Zombie z in zombieList)
            {
                for (int i = 0; i < pShootList.Count; i++)
                {
                    if (z.lane == pShootList[i].lane)
                    {
                        switch (pShootList[i].lane)
                        {
                            case 1:
                                yPSP = 150;
                                break;
                            case 2:
                                yPSP = 250;
                                break;
                            case 3:
                                yPSP = 350;
                                break;
                            case 4:
                                yPSP = 450;
                                break;
                            case 5:
                                yPSP = 550;
                                break;
                        }
                        PeaShooterProjectiles pea = new PeaShooterProjectiles(pShootList[i].x + (peaWidth / 3), yPSP);

                        pShootProjectileList.Add(pea);
                    }
                }
            }
        }


        private void zombieTimer_Tick(object sender, EventArgs e)
        {
            //check if a zombie has managed to get to a plant
            // make sure that zombie cant eat plants from different lanes
            foreach (Zombie z in zombieList)
            {
                for (int i = 0; i < pShootList.Count; i++)
                {
                    if (z.Collision(pShootList[i]) && z.lane == pShootList[i].lane)
                    {
                        //remove a life, delete peashooter at 0 life
                        pShootList[i].life--;
                        if (pShootList[i].life < 1)
                        {
                            pShootList.Remove(pShootList[i]);
                        }
                        return;
                    }
                }

            }
            foreach (Zombie z in zombieList)
            {
                for (int i = 0; i < sunFlowerList.Count; i++)
                {
                    if (z.CollisionSun(sunFlowerList[i]) && z.lane == sunFlowerList[i].lane)
                    {
                        //remove a life, delete peashooter at 0 life
                        sunFlowerList[i].life--;
                        if (sunFlowerList[i].life < 1)
                        {
                            sunFlowerList.Remove(sunFlowerList[i]);
                        }
                        return;
                    }
                }

            }
        }

        #region SunSpawning
        private void sunFlowerTimer_Tick(object sender, EventArgs e)
        {
            foreach (SunFlower f in sunFlowerList)
            {
                //create sun on top of the sunflower every tick
                Sun u = new Sun(f.x + 5, f.y);
                sunList.Add(u);
            }
        }
        //timer ticks every 10 seconds, then create an object to gain currency
        private void sunTimer_Tick(object sender, EventArgs e)
        {
            Sun sun = new Sun(r.Next(101, 990), 100);
            sunList.Add(sun);
        }
        #endregion

        private void zombieSpawn_Tick(object sender, EventArgs e)
        {
            // spawn zombies every 30 seconds, if enough time passed, increase difficulty

            Zombie zombie = new Zombie(1, r.Next(1, 6), 1);
            zombieList.Add(zombie);
            if (survivalTimer.ElapsedMilliseconds >= 1 * 60 * 1000)
            {
                Zombie zombie1 = new Zombie(2, r.Next(1, 6), 1);
                zombieList.Add(zombie1);
            }
            if (survivalTimer.ElapsedMilliseconds >= 2 * 60 * 1000)
            {
                Zombie zombie3 = new Zombie(3, r.Next(1, 6), 1);
                zombieList.Add(zombie3);
            }
            if (survivalTimer.ElapsedMilliseconds >= 2.5 * 60 * 1000)
            {
                Zombie zombie3 = new Zombie(3, r.Next(1, 6), 1);
                zombieList.Add(zombie3);
            }
        }
    }
}

         


