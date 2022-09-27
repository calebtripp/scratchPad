using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace scratchPad
{
    internal abstract class Boat : Vehicle
    {
        public override abstract string Name { get; set; } = "Pontoon";
        public override abstract int VehicleID { get; set; } = 13;

        public override void Move()
        {
            Console.WriteLine("push throttle forward");
        }  
        public override void Stop()
        {
            Console.WriteLine("drop anchor");
        }


    }
}
