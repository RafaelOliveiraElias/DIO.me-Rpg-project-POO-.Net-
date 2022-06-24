using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIORpg.src.Entities
{
    public class Wizard : Hero
    {
    public Wizard(string name, int level, string heroType) : base(name, level, heroType)
    {
    }

    public override string Attack(int? Bonus)
    {
        return this.name + " atacou com magia branca.";
    }


    }
}