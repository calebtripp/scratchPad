using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace scratchPad
{
    internal abstract class Plane : Vehicle
    {
        public override abstract string Name { get; set; }
        public override abstract int VehicleID { get; set; }

        private readonly int _blackboxID = 1324;
        public override void Move()
        {
            Console.WriteLine("start prop");
        }
        public override void Stop()
        {
            Console.WriteLine("land dont crash, slow down");
        }
             public override void PrintVehicleInfo()
        {
            Console.WriteLine("something");
            Console.WriteLine(VehicleID);
            Console.WriteLine(Name);
            Console.WriteLine(_blackBoxID);
        }
    
        //  newVehicle... new it up
    }
}
