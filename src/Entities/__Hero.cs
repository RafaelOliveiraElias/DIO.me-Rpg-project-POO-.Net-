using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIORpg.src.Entities
{
    public abstract class Hero
    {      
        public Hero(string name, int level, string heroType, int life)
        {
            this.name = name;
            this.level = level;
            this.heroType = heroType;
            this.life = life;
        }
        public string? name { get; set; }

        public int level;
        public int life;


        public string? heroType;

        public override string ToString()
        {
            return $"Nome: {this.name} | Level: {this.level} | Classe: {this.heroType} | HP Atual: {this.life}";
        }

        public virtual string Attack()
        {
            return this.name + " atacou com sua espada";
        }   

        public virtual string Attack(int Bonus)
        {
            if(Bonus > 6)
            {
                return this.name + " atacou com espada com bonus de " + Bonus;
            }
            return this.name + " atacou com espada com bonus de " + Bonus;
        }

        
    }
}