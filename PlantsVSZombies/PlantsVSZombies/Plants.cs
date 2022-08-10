using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlantsVSZombies
{
    class Plants:Common
    {
        private static Random rnd = new Random();
        private int width, height;
        List<Plants> plants = new List<Plants>();
        public Plants(int x, int y, int hp):base(x,y,hp,0,Convert.ToChar("0"))
        {
             plants = new List<Plants>();

            width = 3;
            height = 3;
        }
        private Plants CreateNewPlants()
        {
            int x = rnd.Next(0, width);
            int y = rnd.Next(0, height);
            int hp = rnd.Next(3, 10);

            Plants plants = new Plants(x, y, hp);

            return plants;
        }
        public void AddPlants(int count)
        {
            for (int i = 0; i < count; i++)
            {
                plants.Add(CreateNewPlants());
            }
        }

   
    }
}
