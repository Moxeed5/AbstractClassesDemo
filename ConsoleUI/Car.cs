using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class Car : Vehicle
    {
        public override void DriveAbstract()
        {
            Console.WriteLine("Drive the car");
            
        }

        public bool HasTrunk { get; set; }
    }
}
