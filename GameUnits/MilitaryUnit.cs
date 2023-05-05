using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameUnits
{
    public class MilitaryUnit : Unit
    {

        public int AttackPower{get;}
        public int XP {get; private set;}
        public override int Health { get => base.Health + XP;}
        public override float Cost => AttackPower + XP;
        public MilitaryUnit(int mov, int health, int attackPower) : base(mov, health)
        {
            AttackPower = attackPower;
            XP = 0;
        }

        public void Attack(Unit u)
        {
            XP++;
            u.Health--;
        }

        public override string ToString()
        {
            return base.ToString() + $" AP={this.AttackPower} COST={this.XP}" ;
        }
    }
}