using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProgram
{
    class MethodOverloading
    {
        // Method Overloading
        // Method overloading = methods share same name, but different parameters | name + parameters = signature | methods must have a unique signature
        // With method overloading, multiple methods can have the same name with different parameters:
        int PlusMethod(int x, int y)
        {
            return x + y;
        }

        double PlusMethod(double x, double y)
        {
            return x + y;
        }

        static void Main(string[] args)
        {
            MethodOverloading n = new MethodOverloading();

            int myNum1 = n.PlusMethod(8, 5);
            double myNum2 = n.PlusMethod(4.3, 6.5);
            Console.WriteLine("Int: " + myNum1);
            Console.WriteLine("Double: " + myNum2);
        }

    }
}
