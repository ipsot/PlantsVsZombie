using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlantsVSZombies
{
    class Zombies:Common
    {
        Random rnd = new Random();
        public Zombies(int x,int y,int hp, int damage):base(x,y,hp,damage,Convert.ToChar("Z"))
        {

        }
        public void MoveZombie()
        {
            int direction = rnd.Next(0, 2);
            switch (direction)
            {
                case 0:
                    X--;
                    if (X == 1)
                    {
                        X = 1;
                    }
                    break;
            }
            if (X<=0)
            {
                Console.WriteLine("Game Over||||| YouLose");
            }
        }
    }
}
