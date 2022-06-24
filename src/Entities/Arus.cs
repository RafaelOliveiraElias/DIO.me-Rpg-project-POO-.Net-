using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIORpg.src.Entities
{
    public class Arus
    {      
        public Arus(string name, int level, string heroType)
        {
            this.name = name;
            this.level = level;
            this.heroType = heroType;
        }
        public string? name { get; set; }

        public int level;

        public string? heroType;
    }
}