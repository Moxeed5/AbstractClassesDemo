using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo follow all comments!! 
             */

            #region Vehicles

            /*
             * Create an abstract class called Vehicle
             * The vehicle class shall have three string properties Year, Make, and Model
             * Set the defaults to something generic in the Vehicle class
             * Vehicle shall have an abstract method called DriveAbstract with no implementation
             * Vehicle shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Provide the implementations for the abstract methods
             * Only in the Motorcycle class will you override the virtual drive method
            */

            // Create a list of Vehicle called vehicles

            List <Vehicle> vehicleList = new List<Vehicle>();

            Car car1 = new Car()
            {
                Year = 1993,
                Make = "Vovlo",
                Model = "240",
            };



            Motorcycle moto1 = new Motorcycle()
            {
                Year = 2022,
                Make = "BMW",
                Model = "Rav",
            };

            Vehicle car2 = new Car()
            {
                Year = 2009,
                Make = "Toyota",
                Model = "Camry",
            };

            Vehicle moto2 = new Motorcycle()
            {
                Year = 2021,
                Make = "Honda",
                Model = "CRV",
            };

            vehicleList.Add(car1);
            vehicleList.Add(car2);  
            vehicleList.Add(moto1);
            vehicleList.Add(moto2);

            foreach(var item in vehicleList)
            {
                Console.WriteLine($"Make: {item.Make}");
                Console.WriteLine($"Model: {item.Model}");
                Console.WriteLine($"Year: {item.Year}");
                Console.WriteLine();
            }

            car1.DriveAbstract();
            moto1.DriveAbstract();
            moto1.DriveVirtual();
            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * 
             * Set the properties with object initializer syntax
             */

            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */

            // Call each of the drive methods for one car and one motorcycle

            #endregion            
            Console.ReadLine();
        }
    }
}
