using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIORpg.src.Entities
{
    public abstract class Hero
    {      
        public Hero(string name, int level, string heroType)
        {
            this.name = name;
            this.level = level;
            this.heroType = heroType;
        }
        public string? name { get; set; }

        public int level;

        public string? heroType;

        public override string ToString()
        {
            return $"{this.name} {this.level} {this.heroType}";
        }

        public virtual string Attack(int? Bonus)
        {
            return this.name + " atacou com sua espada";
        }

        
    }
}