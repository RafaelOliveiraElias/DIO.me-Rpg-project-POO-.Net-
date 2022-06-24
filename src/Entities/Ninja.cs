using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIORpg.src.Entities
{
    public class Ninja : Hero
    {
        public Ninja(string name, int level, string heroType, int life) : base(name, level, heroType, life)
        {
        }

        public override string Attack()
        {
            return this.name + " atacou com sua shuriken";
        }

        public override string Attack(int Bonus)
        {
            if(Bonus > 6)
            {
                return this.name + " atacou com shuriken com bonus de " + Bonus;
            }
            return this.name + " atacou com shuriken com bonus de " + Bonus;
        }
    }
}