using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchaarSteenPapier
{
    public class Spel
    {
        // Speler 1
        private Speler playerOneValue;

        public Speler PlayerOne
        {
            get { return playerOneValue; }
            set { playerOneValue = value; }
        }

        // Speler 2
        private Speler playerTwoValue;

        public Speler PlayerTwo
        {
            get { return playerTwoValue; }
            set { playerTwoValue = value; }
        }

        // Aantal keren gelijkspel
        private int gelijkspelValue;

        public int Gelijkspel
        {
            get { return gelijkspelValue; }
            set { gelijkspelValue = value; }
        }

        // Aantal gespeelde beurten
        private int beurtValue;

        public int Beurt
        {
            get { return beurtValue; }
            set { beurtValue = value; }
        }

        // Datetime om te bepalen wanneer de console de laatste keer is geupdate.
        private DateTime timeValue;

        public DateTime Time
        {
            get { return timeValue; }
            set { timeValue = value; }
        }


        // Constructor
        public Spel(Speler een, Speler twee)
        {
            this.PlayerOne = een;
            this.PlayerTwo = twee;
            this.Time = DateTime.Now;
        }

        public void SpeelBeurt()
        {
            if (UpdateConsole())
                Console.Clear();
            if (SelecteerWinnaar(PlayerOne.SpeelBeurt(), PlayerTwo.SpeelBeurt()) == 1)
            {
                if(UpdateConsole())
                    Console.WriteLine("Speler 1 wint deze ronde!");
                PlayerOne.Score++;
            }
            else if (SelecteerWinnaar(PlayerOne.SpeelBeurt(), PlayerTwo.SpeelBeurt()) == 2)
            {
                if (UpdateConsole())
                    Console.WriteLine("Speler 2 wint deze ronde!");
                PlayerTwo.Score++;
            }
            else
            {
                if (UpdateConsole())
                    Console.WriteLine("Gelijkspel!");
                Gelijkspel++;
            }
            if (UpdateConsole())
                Scores();
            
        }

        private bool UpdateConsole()
        {
            if(DateTime.Now.Subtract(Time).Seconds > 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Geeft de scores weer
        private void Scores()
        {
            Console.WriteLine(PlayerOne.ToString() + "\n" + PlayerTwo.ToString() + "\nAantal x gelijkspel: " + Gelijkspel);
        }

        // Return 1 als P1 gewonnen heeft, 2 als P2 gewonnen heeft en 0 bij gelijkspel.
        private int SelecteerWinnaar(int P1, int P2)
        {
            if (P1 == P2)
            {
                return 0;
            }
            else if ((P1 == 1 && P2 == 3) || (P1 == 2 && P2 == 1) || (P1 == 3 && P2 == 2))
            {
                return 1;
            }
            else
            {
                return 2;
            }
        }
    }
}
