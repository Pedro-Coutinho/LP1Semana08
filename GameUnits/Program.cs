using System;

namespace GameUnits
{
    class Program
    {
        static void Main(string[] args)
        {
            Unit[] units = new Unit[2];

            units[0] = new MilitatyUnit(3, 6, 3);
            units[1] = new SettlerUnit();

            foreach(Unit u in units)
            {
                u.Move();
                Console.WriteLine(u.Health);
                Console.WriteLine(u.Cost);
            }
        }
    }
}
