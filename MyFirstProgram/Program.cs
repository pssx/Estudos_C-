using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MyFirstProgram
{
     class Program
    {
        static void Main(string[] args)
        {
            // Metodo Estatico da Propria  Classe
            Class.Hello();
            Class.Waiting();
            Class.Bye();


            //Console.Beep(); 

            /*
            comment
            */

            //Console.WriteLine("Paulo\nVinicius");
            //Console.ReadKey(); // not close prog until press a key




            static void Variables()
            {
                int x; // declaration
                x = 123; // initialization
                int y = 321; // declaration + initialization
                int z = x + y;

                int age = 23; // whole integer
                double height = 300.5; // decimal number
                bool alive = false; //true or false
                char symbol = '@'; // single character
                String name = "PV"; // a series of characters
                const double pi = 3.14;

                Console.WriteLine("Hello " + name);
                Console.WriteLine("Your age is " + age);
                Console.WriteLine("Your height is " + height + "cm");
                Console.WriteLine("Are you alive? " + alive);
                Console.WriteLine("Your symbol is: " + symbol);
                String userName = symbol + name;
                Console.WriteLine("Your username is: " + userName);
                Console.ReadKey();
                Console.WriteLine();

            }

            static void TypeCasting()
            {
                double a = 3.14;
                int b = Convert.ToInt32(a);

                int c = 123;
                double d = Convert.ToDouble(c);

                int e = 321;
                String f = Convert.ToString(e);

                String g = "$";
                char h = Convert.ToChar(g);

                String i = "true";
                bool j = Convert.ToBoolean(i);

                Console.WriteLine(b.GetType());
                Console.WriteLine(d.GetType());
                Console.WriteLine(f.GetType());
                Console.WriteLine(h.GetType());
                Console.WriteLine(j.GetType());
                Console.ReadKey();
                Console.WriteLine();

            }

            static void UserInput()
            {
                Console.WriteLine("What's your age?");
                String nameX = Console.ReadLine();

                Console.WriteLine("What's your age?");
                int ageX = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Hello " + nameX);
                Console.WriteLine("You are " + ageX + " years old");
                Console.WriteLine();
            }

            static void ArithmeticOperators()
            {
                int friends = 5;

                friends = friends + 1;
                //friends += 1; 
                //friends++;

                //friends = friends - 1;
                //friends -= 1;
                //friends--;

                //friends = friends * 2;
                //friends *= 2;

                //friends = friends / 2;
                //friends /= 2;

                //int remainder = friends % 2;
                //Console.WriteLine(remainder);

                Console.WriteLine(friends);

                Console.ReadKey();

            }

            static void MathClass()
            {
                double x = 3.14;
                double y = 5;

                double a = Math.Pow(x, 2); // Retorna um número especificado elevado à potência especificada.
                double b = Math.Sqrt(x);   // Método retorna raiz quadrada de x
                double c = Math.Abs(x);    // Método retorna o valor absoluto (positivo) de x
                double d = Math.Round(x);  // Arredonda número para um inteiro mais próximo
                double e = Math.Ceiling(x);// Retorna o menor valor integral maior ou igual ao número decimal especificado
                double f = Math.Floor(x);  // Retorna o maior valor integral menor ou igual ao número decimal especificado.
                double g = Math.Max(x, y); // Método encontrar valor mais alto de x e y
                double h = Math.Min(x, y); // Método encontrar menor valor de x e y

                Console.WriteLine(d);

                Console.ReadKey();
            }

            static void RandomNum()
            {
                Random random = new Random();

                double num = random.NextDouble();
                int num1 = random.Next(1, 7);
                int num2 = random.Next(1, 7);
                int num3 = random.Next(1, 7);

                Console.WriteLine(num);
                Console.WriteLine(num1);
                Console.WriteLine(num2);
                Console.WriteLine(num3);

                Console.ReadKey();
            }

            static void StringMethods()
            {
                String fullName = "Bro Code";
                String phoneNumber = "123-456-7890";

                //fullName = fullName.ToUpper();
                //fullName = fullName.ToLower();
                //Console.WriteLine(fullName);

                //phoneNumber = phoneNumber.Replace("-","");
                //Console.WriteLine(phoneNumber);

                //String userName = fullName.Insert(0,"Mr.");
                //Console.WriteLine(userName);

                //Console.WriteLine(fullName.Length);

                String firstName = fullName.Substring(0, 3);
                String lastName = fullName.Substring(4, 4);

                Console.WriteLine(firstName);
                Console.WriteLine(lastName);
                string name = string.Concat(firstName, lastName); // concatenate two strings, string name = firstName + lastName



                // Outra opção de concatenação de strings é a interpolação de strings , que substitui valores de variáveis ​​em espaços reservados em uma string
                string firstNameX = "John";
                string lastNameX = "Doe";
                string nameX = $"My full name is: {firstNameX} {lastNameX}";
                Console.WriteLine(nameX);


                string myString1 = "Hello";
                Console.WriteLine(myString1[1]);  // Outputs "e"
                string myString2 = "Hello";
                Console.WriteLine(myString2.IndexOf("e"));  // Outputs "1"

                Console.ReadKey();


            }

            static void IfElse()
            {


                /*
                 Less than: a < b
                 Less than or equal to: a <= b
                 Greater than: a > b
                 Greater than or equal to: a >= b
                 Equal to a == b
                 Not Equal to: a != b

                 Use if to specify a block of code to be executed, if a specified condition is true
                 Use else to specify a block of code to be executed, if the same condition is false
                 Use else if to specify a new condition to test, if the first condition is false
                 
                 Use switch to specify many alternative blocks of code to be executed
                 */

                int x = 20;
                int y = 18;
                if (x > y)
                {
                    Console.WriteLine("x is greater than y");
                }



                Console.WriteLine("Please enter your name: ");
                String name = Console.ReadLine();
                if (name == "")
                {
                    Console.WriteLine("You did not enter your name!");
                }
                else
                {
                    Console.WriteLine("Hello " + name);
                }
                Console.ReadKey();


                int time = 22;
                if (time < 10)
                {
                    Console.WriteLine("Good morning.");
                }
                else if (time < 20)
                {
                    Console.WriteLine("Good day.");
                }
                else
                {
                    Console.WriteLine("Good evening.");
                }


                //Short Hand If...Else(Ternary Operator)
                // variable = (condition) ? expressionTrue :  expressionFalse;
                double temperature = 20;
                String message;

                message = (temperature >= 15) ? "It's warm outside!" : "It's cold outside!";

                Console.WriteLine(message);

                Console.ReadKey();














            }

            static void Switch()
            {
                int day = 4;

                switch (day)
                {
                    case 1:
                        Console.WriteLine("Monday");
                        break;
                    case 2:
                        Console.WriteLine("Tuesday");
                        break;
                    case 3:
                        Console.WriteLine("Wednesday");
                        break;
                    case 4:
                        Console.WriteLine("Thursday");
                        break;
                    case 5:
                        Console.WriteLine("Friday");
                        break;
                    case 6:
                        Console.WriteLine("Saturday");
                        break;
                    case 7:
                        Console.WriteLine("Sunday");
                        break;
                }
                // Outputs "Thursday" (day 4)



                int dayX = 4;
                switch (dayX)
                {
                    case 6:
                        Console.WriteLine("Today is Saturday.");
                        break;
                    case 7:
                        Console.WriteLine("Today is Sunday.");
                        break;
                    default:
                        Console.WriteLine("Looking forward to the Weekend.");
                        break;
                }
                // Outputs "Looking forward to the Weekend."
                // default keyword is optional and specifies some code to run if there is no case match:





            }

            static void LogicalOperators()
            {

                // logical operators = Can be used to check if more than 1 condition is true/false

                // && (AND)
                // || (OR)

                Console.WriteLine("What's the temperature outside: (C)");
                double temp = Convert.ToDouble(Console.ReadLine());

                if (temp >= 10 && temp <= 25)
                {
                    Console.WriteLine("It's warm outside!");
                }
                else if (temp <= -50 || temp >= 50)
                {
                    Console.WriteLine("DO NOT GO OUTSIDE!");
                }


                Console.ReadKey();
            }

            static void While()
            {
                // while loop = repeats some code while some condition remains true
                String name = "";

                while (name == "")
                {
                    Console.Write("Enter your name: ");
                    name = Console.ReadLine();
                }
                Console.WriteLine("Hello " + name);
                Console.ReadKey();


                int i = 0;
                do
                {
                    Console.WriteLine(i);
                    i++;
                }
                while (i < 5);

            }

            static void For()
            {
                // for loop = repeats some code a FINITE amount of times

                // Count up to 10
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine(i);
                }

                // Count down from 10
                for (int i = 10; i > 0; i--)
                {
                    Console.WriteLine(i);
                }
                Console.WriteLine("HAPPY NEW YEAR!");
                Console.ReadKey();



                // nested loop
                Console.Write("How many rows?: ");
                int rows = Convert.ToInt32(Console.ReadLine());

                Console.Write("How many columns?: ");
                int columns = Convert.ToInt32(Console.ReadLine());

                Console.Write("What symbol: ");
                String symbol = Console.ReadLine();

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        Console.Write(symbol); // ve com j !
                    }
                    Console.WriteLine();
                }

                Console.ReadKey();



                //There is also a foreach loop, which is used exclusively to loop through elements in an array:
                string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
                foreach (string i in cars)
                {
                    Console.WriteLine(i);
                }








            }

            static void Calculator()
            {
                do
                {
                    double num1 = 0;
                    double num2 = 0;
                    double result = 0;

                    Console.WriteLine("------------------");
                    Console.WriteLine("Calculator Program");
                    Console.WriteLine("------------------");

                    Console.Write("Enter number 1: ");
                    num1 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Enter number 2: ");
                    num2 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Enter an option: ");
                    Console.WriteLine("\t+ : Add");
                    Console.WriteLine("\t- : Subtract");
                    Console.WriteLine("\t* : Multiply");
                    Console.WriteLine("\t/ : Divide");
                    Console.Write("Enter an option: ");


                    switch (Console.ReadLine())
                    {
                        case "+":
                            result = num1 + num2;
                            Console.WriteLine($"Your result: {num1} + {num2} = " + result);
                            break;
                        case "-":
                            result = num1 - num2;
                            Console.WriteLine($"Your result: {num1} - {num2} = " + result);
                            break;
                        case "*":
                            result = num1 * num2;
                            Console.WriteLine($"Your result: {num1} * {num2} = " + result);
                            break;
                        case "/":
                            result = num1 / num2;
                            Console.WriteLine($"Your result: {num1} / {num2} = " + result);
                            break;
                        default:
                            Console.WriteLine("That was not a valid option");
                            break;
                    }
                    Console.Write("Would you like to continue? (Y = yes, N = No): ");
                } while (Console.ReadLine().ToUpper() == "Y");

                Console.WriteLine("Bye!");
                Console.ReadKey();
            }

            static void BreakContinue()
            {

                for (int i = 0; i < 10; i++)
                {
                    if (i == 4)
                    {
                        break;
                    }
                    Console.WriteLine(i);
                }

                Console.WriteLine();

                for (int i = 0; i < 10; i++)
                {
                    if (i == 4)
                    {
                        continue;
                    }
                    Console.WriteLine(i);
                }
            }

            static void Arrays()
            {
                // Arrays are used to store multiple values in a single variable, instead of declaring separate variables for each value.


                //string[] cars;
                int[] myNum = { 10, 20, 30, 40 };
                string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
                Console.WriteLine(cars[0]); // Outputs Volvo


                string[] carsX = { "Volvo", "BMW", "Ford", "Mazda" };
                carsX[0] = "Opel";
                Console.WriteLine(carsX[0]); // Now outputs Opel instead of Volvo
                Console.WriteLine(carsX.Length); // Outputs 4


                //Other Ways to Create an Array:            
                string[] cars1 = new string[4]; // Create an array of four elements, and add values later

                // Create an array of four elements and add values right away 
                string[] cars2 = new string[4] { "Volvo", "BMW", "Ford", "Mazda" };

                // Create an array of four elements without specifying the size 
                string[] cars3 = new string[] { "Volvo", "BMW", "Ford", "Mazda" };

                // Create an array of four elements, omitting the new keyword, and without specifying the size
                string[] cars4 = { "Volvo", "BMW", "Ford", "Mazda" };



                // Multidimensional Arrays
                String[,] parkingLot = { { "Mustang", "F-150", "Explorer" },
                                                   { "Corvette", "Camaro", "Silverado" },
                                                   { "Corolla", "Camry", "Rav4" }
                                                 };
                parkingLot[0, 2] = "Fusion";
                parkingLot[2, 0] = "Tacoma";
                /*
                foreach(String car in parkingLot)
                {
                    Console.WriteLine(car);
                }
                */
                for (int i = 0; i < parkingLot.GetLength(0); i++)
                {
                    for (int j = 0; j < parkingLot.GetLength(1); j++)
                    {
                        Console.Write(parkingLot[i, j] + " ");
                    }
                    Console.WriteLine();
                }
                Console.ReadKey();


            }

            static void Method()
            {
                static void MyMethod(string fname, int age){
                    Console.WriteLine(fname + " is " + age);
                }
                MyMethod("Nati", 13);
                MyMethod("Jenny", 8);
                MyMethod("PauloV", 23);



                static void MyMethod2(string country = "Norway"){
                    Console.WriteLine(country);
                }
                MyMethod2("Sweden");
                MyMethod2("India");



                static int MyMethod3(int x){
                    return 5 + x;
                }
                Console.WriteLine(MyMethod3(3));



                static void MyMethod4(string child1, string child2, string child3){
                    Console.WriteLine("The youngest child is: " + child3);
                }
                MyMethod4(child3: "John", child1: "Liam", child2: "Liam");






                



                

            }

            static void Exceptions_Try_Catch() {
                int x;
                int y;
                double result;

                try
                {
                    Console.Write("Enter number 1: ");
                    x = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Enter number 2: ");
                    y = Convert.ToInt32(Console.ReadLine());

                    result = x / y;

                    Console.WriteLine("result: " + result);
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Enter ONLY numbers PLEASE!");
                }
                catch (DivideByZeroException e)
                {
                    Console.WriteLine("You can't divide by zero!");
                }
                catch (Exception e)
                {
                    Console.WriteLine("Something went wrong!");
                }
                finally
                {
                    Console.WriteLine("Thanks for visiting!");
                }

                Console.ReadKey();

            }

            static void List() {
                // List = data structure that represents a list of objects that can be accessed by index.
                //        Similar to array, but can dynamically increase/decrease in size 
                //        using System.Collections.Generic;

                List<String> food = new List<String>();

                food.Add("pizza");
                food.Add("hamburger");
                food.Add("hotdog");
                food.Add("fries");

                //Console.WriteLine(food[0]);
                //Console.WriteLine(food[1]);
                //Console.WriteLine(food[2]);
                //Console.WriteLine(food[3]);

                //food.Remove("fries");
                //food.Insert(0, "sushi");
                //Console.WriteLine(food.Count);
                //Console.WriteLine(food.IndexOf("pizza"));
                //Console.WriteLine(food.LastIndexOf("fries"));
                //Console.WriteLine(food.Contains("pizza"));
                //food.Sort();
                //food.Reverse();
                //food.Clear();
                //String[] foodArray = food.ToArray();

                foreach (String item in food)
                {
                    Console.WriteLine(item);
                }

                Console.ReadKey();
            }















            //Variables();
            //TypeCasting();
            //UserInput();
            //ArithmeticOperators();

            //MathClass();
            //RandomNum();
            //StringMethods();

            //IfElse();
            //Switch();
            //LogicalOperators();
            //While();
            //For();

            //Calculator();
            //BreakContinue();

            //Arrays();
            //List();

            //Method();
            //Exceptions_Try_Catch();
        }
    }                                                                          
}
