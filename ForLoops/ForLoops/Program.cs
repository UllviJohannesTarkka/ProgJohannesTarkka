using System;
using System.Threading;

namespace ForLoops
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            /*
            int i = 0;

            while(i < 10)
            {
                Console.WriteLine("du gay" + i);
                Thread.Sleep(1000);
                i++;
            }

            for (int i = -10; i < 1100000; i++)
            {
                int y = 3 * i + 5;
                Console.WriteLine("i: " + i + "| f(" + i + ")=3*" + i + "+ 5 = " + y);
                Console.WriteLine("i: {0}| f({0}) = 3*{0} + 5 ={1}", i, y);
                Thread.Sleep(10);
            }


            Console.WriteLine("Welcome to my domain, write a number");
            double x = -10.0;
            while(true)
            {
                try
                {
                    string homo = Console.ReadLine();
                    x = double.Parse(homo);
                    break;
                }
                catch
                {
                    Console.WriteLine("A number you idiot");
                }
            }
            */
            Console.WriteLine("Choose a function");
            Console.WriteLine("1: g(x)= x^2+10x-25\n" +
                              "2: f(x)= 2x-7\n" +
                              "3: h(x)= 3x^5-x^4+4x^3-2x^2+10x-25");

            int gay = -5;
            try
            {
                string choice = Console.ReadLine();
                gay = int.Parse(choice);
                for (int x = -10; x < 11; x++)
                {
                    switch (gay)
                    {
                        case 1:
                            double y1 = Math.Pow(x, 2) + 10 * x - 25;
                            Console.WriteLine("f(" + x + ")= " + y1);
                            break;

                        case 2:
                            double y2 = 2 * x - 7;
                            Console.WriteLine("f(" + x + ")= " + y2);
                            break;
                        case 3:
                            double y3 = 3 * Math.Pow(x, 5) - Math.Pow(x, 4) + 4 * Math.Pow(x, 3) - 2 * Math.Pow(x, 2) + 10 * x - 25;
                            Console.WriteLine("f(" + x + ")= " + y3);
                            break;
                        default:
                            Console.WriteLine("You can't choose that");
                            continue;

                    }
                }
            }
            catch
            {
                Console.WriteLine("Are you retarded?");
            }
        }
    }
}