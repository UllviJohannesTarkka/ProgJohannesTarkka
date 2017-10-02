using System;
using System.Threading;

namespace FrageSport
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            
            int points = 0;
            /*
            Console.WriteLine("Välkommen till min frågesport!");

            //Fråga 1
            Console.WriteLine("Vilken färg har gräs?");
            string svar = Console.ReadLine();
            if(svar.ToLower() == "grön" || svar.ToLower() == "grönt")
            {
                Console.WriteLine("RÄTT\n");
                points++;
            }
            else
            {
                Console.WriteLine("FEL\n");
            }
            Thread.Sleep(1000);

            //Fråga 2
            Console.WriteLine("Fråga 2");
			Console.WriteLine("Vad är det som täcker 71% av Jorden?");
			svar = Console.ReadLine();
			if (svar.ToLower() == "vatten" || svar.ToLower() == "din mamma")
			{
				Console.WriteLine("RÄTT\n");
                points++;
			}
			else
			{
				Console.WriteLine("FEL\n");
			}
            Thread.Sleep(1000);

            //Fråga 3
			Console.WriteLine("Fråga 3");
			Console.WriteLine("Vad är \"glass\" på engelska");
			svar = Console.ReadLine();
			if (svar.ToLower() == "icecream" || svar.ToLower() == "ice cream")
			{
				Console.WriteLine("RÄTT\n");
                points++;
			}
			else
			{
				Console.WriteLine("FEL\n");
			}
            Thread.Sleep(1000);

            //Fråga 4
			Console.WriteLine("Fråga 4");
			Console.WriteLine("Vad heter våran stadsminister?");
			svar = Console.ReadLine();
			if (svar.ToLower() == "stefan löfven")
			{
				Console.WriteLine("RÄTT\n");
                points++;
			}
			else
			{
				Console.WriteLine("FEL\n");
			}
            Thread.Sleep(1000);

            //Fråga 5
            Console.WriteLine("Fråga 5");
			Console.WriteLine("Japans huvudstad är?");
			svar = Console.ReadLine();
			if (svar.ToLower() == "tokyo")
			{
				Console.WriteLine("RÄTT\n");
                points++;
			}
			else
			{
				Console.WriteLine("FEL\n");
			}
            Thread.Sleep(1000);
			//Fråga 6
			Console.WriteLine("Fråga 6");
			Console.WriteLine("Vad ska jag ha för betyg?");
			svar = Console.ReadLine();
			if (svar.ToLower() == "a")
			{
				Console.WriteLine("RÄTT\n");
                points++;
			}
			else
			{
				Console.WriteLine("FEL\n");
			}
            Thread.Sleep(1000);

			//Fråga 7
			Console.WriteLine("Fråga 7");
			Console.WriteLine("Vad är tyngdaccelerationen?");
			svar = Console.ReadLine();
			if (svar == "9,82" || svar == "9.82")
			{
				Console.WriteLine("RÄTT\n");
                points++;
			}
			else
			{
				Console.WriteLine("FEL\n");
			}
            Thread.Sleep(1000);
*/
            //Fråga 8, sifferfråga
            Console.WriteLine("Fråga 8");
            Console.WriteLine("Skriv ett tal mellan 1 & 1 miljon");
            int siffra = -1;
            while (true)
            {
                try
                {
                    siffra = int.Parse(Console.ReadLine());
					if (siffra > 1 && siffra < 1000000)
					{
						Console.WriteLine("RÄTT\n");
						points++;
						break;
					}
					else
					{
						Console.WriteLine("Hur lyckas man inte skriva rätt tal när man har 1 miljon att välja på?\n");
                        points -= 1000000000;
                        break;
					}
                }
                catch
                {
                    Console.WriteLine("Endast siffror, tack!");
                }
            }
            Thread.Sleep(1000);

            //Fråga 9, flervalsfråga
            Console.WriteLine("Fråga 9\nDu har fyra val, ett är korrekt");
            Console.WriteLine("Vad hette Tysklands ledare under andra världskriget?" +
                              "\n1: Josef Stalin" +
                              "\n2: Angela Merkel" +
                              "\n3: Adolf Hitler" +
                              "\n4: Otto von Bismarck");
            int val = -2;
            while (true)
            {

                try
                {
                    string valinm = Console.ReadLine();
                    val = int.Parse(valinm);
                    switch (val)
                    {
                        case 1:
                            Console.WriteLine("FEL");
                            break;

                        case 2:
                            Console.WriteLine("FEL");
                            break;
                        case 3:
                            Console.WriteLine("RÄTT");
                            points++;
                            break;
                        case 4:
                            Console.WriteLine("FEL");
                            break;
                        default:
                            Console.WriteLine("Välj ett alternativ tack!");
                            continue;

                    }
                    break;
                }
                catch
                {
                    Console.WriteLine("Välj ett alternativ tack!");
                }
            }
            Thread.Sleep(1000);

			//Fråga 10, flervalsfråga
			Console.WriteLine("Fråga 10\nDu har två val, ett är korrekt");
			Console.WriteLine("Hentai?" +
							  "\n1: Nej" +
							  "\n2: Ja");
            
			string valinm2 = Console.ReadLine();
            int val2 = -3;
            try
            {
                val2 = int.Parse(valinm2);
            }
            catch
            {
                
            }
            switch (val2)
            {
                case 1:
                    Console.WriteLine("FEL");
                    break;

                case 2:
                    Console.WriteLine("RÄTT");
                    points++;
                    break;
				default:
					Console.WriteLine("Du valde inte ett alternativ så du får FEL");
                    break;
            }
            Thread.Sleep(1000);
            Console.WriteLine("\nBeräknar poäng...");
            Thread.Sleep(3000);
            Console.WriteLine("Du fick " + points + " av 10 poäng");
		}
    }
}
