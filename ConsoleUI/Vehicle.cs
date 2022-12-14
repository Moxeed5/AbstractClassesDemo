using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal abstract class Vehicle
    {
        public string Make { get; set; } = "Toyota";
        public int Year { get; set; } = 2000;

        public string Model { get; set; } = "Camry";

        public abstract void DriveAbstract();


        public virtual void DriveVirtual()
        {
            Console.WriteLine("Drive vehicle w/ virtual method");
        }
    }
}
