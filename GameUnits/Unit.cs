using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameUnits
{
    public abstract class Unit
    {
        private int movement;
        public virtual int Health {get; set;}
        public abstract float Cost {get;}
        public Unit(int mov, int health)
        {
            movement = mov;
            Health = health;
        }

        public void Move()
        {
            Console.WriteLine(movement);
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}: HP={this.Health} COST={this.Cost:f2}" ;
        }
    }
}