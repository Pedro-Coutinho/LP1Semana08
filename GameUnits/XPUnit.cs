using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameUnits
{
    public abstract class XPUnit : Unit
    {
        public int XP{get; protected set;}

        public XPUnit(int mov, int health): base(mov, health)
        {
            XP = 0;
        }

        public override string ToString()
        {
            return base.ToString() + $" XP={this.XP}" ;
        }
    }
}