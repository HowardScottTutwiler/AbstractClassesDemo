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
             * DONE - Create an abstract class called Vehicle
             * DONE - The vehicle class shall have three string properties Year, Make, and Model
             * DONE - Set the defaults to something generic in the Vehicle class
             * DONE - Vehicle shall have an abstract method called DriveAbstract with no implementation
             * DONE - Vehicle shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
             * DONE - Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * DONE - Add a distinct property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * DONE - Provide the implementations for the abstract methods
             * DONE - Only in the Motorcycle class will you override the virtual drive method
            */

            // Create a list holding type Vehicle called vehicles
            // do that here
            var vehicles = new List<Vehicle>();
            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, 
             * and then 2 instances of type Vehicle (use explicit typing) but use constructors from derived classes
             * - new it up as one of each derived class
             * Set the properties with object initializer syntax
             */

            //create a Car object and set values in its properties
            var sedan = new Car() { HasTrunk = true, make = "Olds", model = "Cutlass", year = 1972 };

            //create a MotorCycle object and set values in its properties
            var motorcycle = new Motorcycle() { HasSideCart = true, make = "Honda", model = "550" };

            // twice - create an object of type vehicle with explicit typing: Vehicle whatever = new Car();
            Vehicle sedan2 = new Car()
            {  make = "Acura", model = "TL", year = 2002 };

            Vehicle sedan3 = new Car()
            {  make = "Toyota", model = "Corolla", year = 2003 };
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
