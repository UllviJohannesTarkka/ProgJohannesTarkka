using System;

namespace Primtal
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int x = Math.Abs(Convert.ToInt32(Console.ReadLine()));

            int start = (int)Math.Sqrt(x);

            for (int i = start; i > 1; i--)
            {
                if(x % i == 0)
                {
                    Console.WriteLine("Inte ett primtal");
                }
                else
                {
                    Console.WriteLine("Primtal");
                }
            }
        }
    }
}
