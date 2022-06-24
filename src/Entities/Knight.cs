using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIORpg.src.Entities
{
    public class Knight : Hero
    {
        public Knight(string name, int level, string heroType) : base(name, level, heroType)
        {
        }

        public override string Attack(int? Bonus)
        {
            if(Bonus > 6)
            {
                return this.name + " atacou com magia branca com bonus de " + Bonus;
            }
            return this.name + " atacou com magia branca com bonus de " + Bonus;
        }
    }
}