using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIORpg.src.Entities
{
    public class Knight : Hero
    {
        public Knight(string name, int level, string heroType, int life) : base(name, level, heroType, life)
        {
        }

        public override string Attack()
        {
            return this.name + " atacou com sua espada GIGANTE.";
        }

        public override string Attack(int Bonus)
        {
            if(Bonus > 6)
            {
                return this.name + " atacou com espada GIGANTE com bonus de " + Bonus;
            }
            return this.name + " atacou com espada GIGANTE com bonus de " + Bonus;
        }
    }
}