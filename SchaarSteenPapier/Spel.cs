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

        private int gelijkspelValue;

        public int Gelijkspel
        {
            get { return gelijkspelValue; }
            set { gelijkspelValue = value; }
        }


        // Constructor
        public Spel(Speler een, Speler twee)
        {
            this.PlayerOne = een;
            this.PlayerTwo = twee;
        }

        public void SpeelBeurt()
        {
            Console.Clear();
            if (SelecteerWinnaar(PlayerOne.SpeelBeurt(), PlayerTwo.SpeelBeurt()) == 1)
            {
                Console.WriteLine("Speler 1 wint deze ronde!");
                PlayerOne.Score++;
            }
            else if (SelecteerWinnaar(PlayerOne.SpeelBeurt(), PlayerTwo.SpeelBeurt()) == 2)
            {
                Console.WriteLine("Speler 2 wint deze ronde!");
                PlayerTwo.Score++;
            }
            else
            {
                Console.WriteLine("Gelijkspel!");
                Gelijkspel++;
            }
            // Geeft de scores weer
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
