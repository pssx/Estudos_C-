using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProgram
{
    class ArrayObjects
    {
        static void Main(string[] args)
        {


            CarU[] garage = { new CarU("Mustang"), new CarU("Corvette"), new CarU("Lambo") };

            /*
            CarU[] garage = new CarU[3];
            CarU carU1 = new CarU("XY");
            CarU carU2 = new CarU("X");
            CarU carU3 = new CarU("Y");
            garage[0] = carU1;
            garage[1] = carU2;
            garage[2] = carU3;
            */

            foreach (CarU carU in garage)
            {
                Console.WriteLine(carU.modelU);
            }

            Console.ReadKey();
        }
    }
    class CarU
    {
        public String modelU;

        public CarU(String model)
        {
            this.modelU = modelU;

        }
    }
}
