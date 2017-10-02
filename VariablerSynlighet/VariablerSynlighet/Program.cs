using System;

namespace VariablerSynlighet
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            int points = 0;

            int val = -1;
            Console.WriteLine("Hur gammal är jag?");

            try
            {
                val = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Svaret måste vara i sifferform");
            }
            if (val == 16)
            {
                Console.WriteLine("RÄTT");
                points++;
            }
            else
            {
                Console.WriteLine("FEL");
            }

            Console.WriteLine(points);
        }
    }
}
