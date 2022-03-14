using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintballSim
{
    class PaintBallGun
    {
        public PaintBallGun(int balls, int magazineSize, bool loaded)
        {
            this.balls = balls;
            MagazineSize = magazineSize;
            if (!loaded) Reload();
        }
        public int MagazineSize { get; private set; } = 16;

        private int balls = 0;

        public int BallsLoaded { get; private set; }
        public bool IsEmpty() { return BallsLoaded == 0; } // mini method for when we run out of ammo (not really neccesary the way we're using the class)

        public int Balls // declare the property
        {
            get { return balls; } // "getter" lets us access the balls we have left
            set                   // "setter" lets us change the value of balls
            {
                if (value > 0)
                    balls = value;
                Reload();
            }
        }

        public void Reload()
        {
            if (BallsLoaded > MagazineSize)
                BallsLoaded = MagazineSize; /* loads gun with a full magazine 
                                               (not the best way to do it because if the BallsLoaded is higher than the magazine size, it resets the magazine size back to a lower number */
            else
                BallsLoaded = balls; /* or just fills up with whatever is left for ammo 
                                      (this one is also weird because it never subtracts from the balls, so realistically it does not make sesnse) */
        }
        public bool Shoot() // gotta be able to shoot our gun
        {
            if (BallsLoaded == 0) return false; // out of ammo :(
            BallsLoaded--;
            balls--;
            return true;
        }
    }
}
