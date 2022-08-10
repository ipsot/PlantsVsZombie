using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlantsVSZombies
{
    class Program
    {
        static void Main(string[] args)
        {
            Plants plants = new Plants(1,1,5);
            List<Zombies> zombies = new List<Zombies>()
            {
                new Zombies(1,1,6,3)

            };
            while (plants.IsAlive)
            {
                Console.Clear();
                System.Threading.Thread.Sleep(1000);

                foreach(Zombies zombie in zombies)
                {
                    zombie.Print();
                }
                plants.Print();


                foreach(Zombies zombie in zombies)
                {
                    if (plants.IsCollisionAnotherObject(zombie))
                    {
                        plants.TakeDamage(zombie);
                    }
                }
            }
           
            Console.Clear();
            Console.ReadKey();
        }
    }
    
}
