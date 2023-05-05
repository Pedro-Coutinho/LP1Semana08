using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameUnits
{
    public class SpyUnit : XPUnit
    {
        public override float Cost{get;}
        public SpyUnit() : base(8, 2)
        {
            Cost = 12.5f;
        }

        public void GetSecretInfo(Unit u)
        {
            string type = u.GetType().Name;

            switch(type) 
            {
            case "SpyUnit":
                XP += 3;
                break;
            case "MilitaryUnit":
                XP += 2;
                break;
            default:
                XP++;
                break;
            }
        }
    }
}