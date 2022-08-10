using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlantsVSZombies
{
    class Bullet:Common
    {
        public Bullet(int x,int y,double speed,int damage,char view):base(x,y,1,damage,Convert.ToChar("=>"))
        {

        }

    }
}
