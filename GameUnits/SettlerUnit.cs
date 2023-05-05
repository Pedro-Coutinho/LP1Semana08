using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameUnits
{
    public class SettlerUnit : Unit
    {
        public override float Cost {get;}
        public SettlerUnit() : base(1, 2)
        {
            Cost = 5;
        } 
    }
}