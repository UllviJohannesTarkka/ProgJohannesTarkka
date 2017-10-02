using System;

namespace WhileLoop
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            /*
            char forsokigen = 'y';

            while (forsokigen == 'y')
            {
                Console.WriteLine("Gillar man kuk är man?");
                string svar = Console.ReadLine();

                if (svar.ToLower() == "gay")
                {
                    Console.WriteLine("BLaGh");
                           break;
                }
                else
                {
                    Console.WriteLine("Blegh");
                    forsokigen = Console.ReadLine()[0];
                }

            }


            Random randomizer = new Random();
            int random = 0;
            int svar = -1;
            while(svar != random)
            {
                random = randomizer.Next(1, 101);
                Console.WriteLine("Hurr durr");
                svar = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("RNGesus!!");
            */

            int talet = -1;

            while(true)
            {
                Console.WriteLine("Gey");

                try
                {
                    talet = int.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Do you honestly think you're fucking funny?");
                }
            }
        }
    }
}
