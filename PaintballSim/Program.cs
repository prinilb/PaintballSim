using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintballSim
{
    class Program
    {
        static void Main(string[] args)
        {
            PaintBallGun gun = new PaintBallGun(); 

            while (true)
            {
                Console.WriteLine($"{gun.Balls} balls, {gun.BallsLoaded} loaded"); 

                if (gun.IsEmpty()) Console.WriteLine("WARNING: You're out of ammo"); // a truly tragic event

                Console.WriteLine("Space to shoot, r, to reload, + to add ammo, q to quit");
                char key = Console.ReadKey(true).KeyChar;

                if (key == ' ')
                {
                    Console.WriteLine($"Shooting returned {gun.Shoot()}");
                }
                else if (key == 'r') gun.Reload();
                else if (key == '+') gun.Balls += PaintBallGun.MAGAZINE_SIZE;
                else if (key == 'q') return;
            }
        }
    }
}
