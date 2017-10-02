using System;
using System.Threading;

namespace Heltal
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Välkommen till min kalkylator! Vad vill du göra?\n" +
                              "1: Addera\n" +
                              "2: Subtrahera\n" +
                              "3: Dividera\n" +
                              "4: Multiplicera\n");

			string Inm = Console.ReadLine();
			int val = int.Parse(Inm);

			Console.WriteLine("Skriv ett tal");
			String inmatning1 = Console.ReadLine();
			double tal1 = double.Parse(inmatning1);

			Console.WriteLine("Skriv in ett till tal");
			String inmatning2 = Console.ReadLine();
			double tal2 = double.Parse(inmatning2);

            var addera = (tal1 + tal2);
            var subtrahera = (tal1 - tal2);
            var dividera = (tal1 / tal2);
            var multiplicera = (tal1 * tal2);

            switch (val)
            {
                case 1:
                    Console.WriteLine("Summan är:" + (addera));
                    break;

                case 2:
					Console.WriteLine("Differensen är:" + (subtrahera));
                    break;

                case 3:
                    Console.WriteLine("Kvoten är:" + (dividera));
                    break;

                case 4:
                    Console.WriteLine("Produkten är:" + (multiplicera));
                    break;

                default:
                    Console.WriteLine("Du valde ej en giltig räknemetod");
                    break;
            }
        }
    }
}
