using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace scratchPad
{
    internal abstract class Vehicle  //hybrind base class abstract
    {
        private readonly int _blackboxID;
            public abstract int VehicleID { get; set; }
        public abstract string Name { get; set; }

        public abstract void Move(); // if marked abstract, MUST be used in Derived or concrete class
        public abstract void Stop();
        public virtual void PrintVehicleInfo()
        // public void PrintSomething()
             
        {
            Console.WriteLine("something");
            Console.WriteLine(VehicleID);
            Console.WriteLine(Name);
        }
    }
}
