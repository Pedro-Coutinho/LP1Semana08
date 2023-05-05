using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameUnits
{
    public class MilitaryUnit : XPUnit
    {

        public int AttackPower{get;}
        public override int Health { get => base.Health + XP;}
        public override float Cost => AttackPower + XP;
        public MilitaryUnit(int mov, int health, int attackPower) : base(mov, health)
        {
            AttackPower = attackPower;
        }

        public void Attack(Unit u)
        {
            XP++;
            u.Health--;
        }

        public override string ToString()
        {
            return base.ToString() + $" AP={this.AttackPower}" ;
        }
    }
}