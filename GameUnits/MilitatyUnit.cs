using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameUnits
{
    public class MilitatyUnit : Unit
    {

        public int AttacPower{get;}
        public int XP {get; private set;}
        public override int Health { get => base.Health + XP;}
        public override float Cost => AttacPower + XP;
        public MilitatyUnit(int mov, int health, int attackPower) : base(mov, health)
        {
            AttacPower = attackPower;
            XP = 0;
        }

        public void Attack(Unit u)
        {
            XP++;
            u.Health--;
        }
    }
}