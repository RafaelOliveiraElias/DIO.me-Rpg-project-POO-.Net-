using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIORpg.src.Entities
{
    public class Wizard : Hero
    {
    public Wizard(string name, int level, string heroType, int life) : base(name, level, heroType, life)
    {
    }

    public override string Attack()
    {
        return this.name + " atacou com magia branca.";
    }

    public override string Attack(int Bonus)
        {
            if(Bonus > 6)
            {
                return this.name + " atacou com magia branca com bonus de " + Bonus;
            }
            return this.name + " atacou com magia branca com bonus de " + Bonus;
        }


    }
}