using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProgram
{
    class AbstractClasses
    {
        static void Main(string[] args)
        {
            // abstract classes =  modifier that indicates missing components or incomplete implementation

            CarY car = new CarY();            
            BicycleY bicycle = new BicycleY();
            BoatY boat = new BoatY();
            //Vehicle vehicle = new Vehicle(); //can't create a vehicle object


            Console.ReadKey();
        }
    }
    abstract class VehicleY
    {
        public int speed = 0;

        public void go()
        {
            Console.WriteLine("This vehicle is moving!");
        }
    }
    class CarY : VehicleY
    {
        public int wheels = 4;
        int maxSpeed = 500;
        
    }
    class BicycleY : VehicleY
    {
        public int wheels = 2;
        int maxSpeed = 50;
    }
    class BoatY : VehicleY
    {
        public int wheels = 0;
        int maxSpeed = 100;
    }
}
