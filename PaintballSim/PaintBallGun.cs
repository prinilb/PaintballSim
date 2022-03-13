using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintballSim
{
    class PaintBallGun
    {
        public const int MAGAZINE_SIZE = 16; // public because it needs to be used by Main()

        private int balls = 0;
        private int ballsLoaded = 0;

        public int GetBallsLoaded() { return ballsLoaded; } // mini method to find out how many balls are loaded in the gun
        public bool IsEmpty() { return ballsLoaded == 0; } // mini method for when we run out of ammo (not really neccesary the way we're using the class)
        public int GetBalls() { return balls; } // find out how much ammo we really got left
        public void SetBalls(int numberOfBalls) 
        {
            if (numberOfBalls > 0)
                ballsLoaded = numberOfBalls;
            Reload();
            /* since the ballsLoaded variable is private (because encapsulation is a good thing), 
               this is the only way we can actually change that variable */
        }

        public void Reload()
        {
            if (ballsLoaded > MAGAZINE_SIZE)
                ballsLoaded = MAGAZINE_SIZE; // loads gun with a full magazine
            else
                ballsLoaded = balls; // or just fills up with whatever is left for ammo
        }

        public bool Shoot() // gotta be able to shoot our gun
        {
            if (ballsLoaded == 0) return false; // out of ammo :(
            ballsLoaded--;
            balls--;
            return true;
        }
    }
}
