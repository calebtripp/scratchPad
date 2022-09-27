using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace scratchPad
{
    internal abstract class Motorcycle : Vehicle
    {

        public override abstract string Name { get; set; }
        public override abstract int VehicleID { get; set; }
        public override void Move()
        {
            Console.WriteLine("Start the bike, kick it into gear");
        }
        public override void Stop()
        {
        Console.WriteLine("Pulling the handbrake");
        }
    }
}
