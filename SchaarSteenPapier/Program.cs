using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchaarSteenPapier
{
    class Program
    {
        static void Main(string[] args)
        {
            int SpelTeller;
            string UserInvoer;
            // Aanmaak van de spelers
            Speler Jef = new Speler("Jef", 1);
            Speler Frank = new Speler("Frank", 2);

            // Initialisatie van het spel
            Spel GameInstance = new Spel(Jef, Frank);

            // User input voor het aantal rondes dat gespeeld dienen te worden. 
            Console.WriteLine("Voer de maximale score in: ");
            UserInvoer = Console.ReadLine();

            // Als de user niets ingeeft, dient het standaard aantal spellen gespeeld te worden. Zie SpelTeller
            if(UserInvoer != null)
            {
                Int32.TryParse(UserInvoer, out SpelTeller);
            }
            else
            {
                SpelTeller = 1000;
            }
            // Speel het spel
            while (GameInstance.PlayerOne.Score < SpelTeller && GameInstance.PlayerTwo.Score < SpelTeller)
            {
                GameInstance.SpeelBeurt();
            }


        }
    }
}
