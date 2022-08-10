using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlantsVSZombies
{
    abstract class Common
    {
        private int x, y;
        private int hp;
        public int count;
        private int damage;
        private char view;
        public int cd;
        private int widthP, heightP,widthZ,heightZ;
        List<Plants> plants = new List<Plants>();
        List<Zombies> zombies = new List<Zombies>();
        Random rnd = new Random();
        protected Common (int x, int y, int hp,int damage, char view)
        {
            this.x = x;
            this.y = y;
            this.hp = hp;
            this.damage = damage;
            this.view = view;

            plants = new List<Plants>();
            zombies = new List<Zombies>();

            widthZ = 200;
            heightZ = 3;

            widthP = 3;
            heightP = 3;
        }


        protected int X
        {
            get { return x; }
            set { x = value; }
        }
        protected int Y
        {
            get { return y; }
            set { y = value; }
        }
        public bool IsAlive
        {
            get { return hp > 0; }
        }
        public bool IsCollisionAnotherObject(Common anotherSubject)
        {
            return x == anotherSubject.x && y == anotherSubject.y;
        }
        public void TakeDamage(Common anotherSubject)
        {
            hp -= anotherSubject.damage;
        }
        private Zombies CreateNewZombies()
        {
            int x = widthZ;
            int y = heightZ;
            int hp = rnd.Next(20,60);
            int damage = rnd.Next(3, 10);
        
            Zombies zombies = new Zombies(x, y, hp,damage);

            return zombies;
        }
        public void AddZombies(int countZ)
        {
            for (int i = 0; i < countZ; i++)
            {
                zombies.Add(CreateNewZombies());
            }
        }
        private Plants CreateNewPlants()
        {
            int x = rnd.Next(0, widthP);
            int y = rnd.Next(0, heightP);
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
       
        public void StartSimulation()
        {
            while (plants.Count> 1)
            {
                Console.Clear();
                ShowPlants();
                ShowZombies();
                System.Threading.Thread.Sleep(10);
            }

            Console.Clear();
            ShowPlants();
            ShowZombies();
        }
        private void ShowPlants()
        {
            for (int i = 0; i < plants.Count; i++)
            {
                plants[i].Print();
            }
        }
        private void ShowZombies()
        {
            for (int i = 0; i <zombies.Count; i++)
            {
                zombies[i].Print();
            }
        }

        public void MakeStep()
        {

            for (int i = 0; i < zombies.Count; i++)
            {
                zombies[i].MoveZombie();
            }
            for (int i = 0; i < plants.Count; i++)
            {
                if (plants[i].IsAlive == false)
                {
                    plants.RemoveAt(i);
                    i = 0;
                }
            }
            for (int i = 0; i < zombies.Count; i++)
            {
                if (zombies[i].IsAlive == false)
                {
                    zombies.RemoveAt(i);
                    i = 0;
                }
            }
        }
        public void Print()
        {
            Console.Write(view);
        }

        
    }
   
}
