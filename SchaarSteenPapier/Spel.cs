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

        // Random object om keuzes te kunnen maken voor de spelers. 
        private Random randomInstanceValue;

        public Random RandomInstance
        {
            get { return randomInstanceValue; }
            set { randomInstanceValue = value; }
        }

        // Constructor
        public Spel(Speler een, Speler twee)
        {
            this.PlayerOne = een;
            this.PlayerTwo = twee;
            this.Time = DateTime.Now;
            this.Beurt = 0;
            this.RandomInstance = new Random();
        }

        public void SpeelBeurt()
        {
            int winner = SelecteerWinnaar(PlayerOne.SpeelBeurt(RandomInstance), PlayerTwo.SpeelBeurt(RandomInstance));
            string winnerString;
            if (winner == 1)
            {
                PlayerOne.Score++;
                winnerString = String.Format("Speler 1 wint beurt {0}", Beurt);
            }
            else if (winner == 2)
            {
                PlayerTwo.Score++;
                winnerString = String.Format("Speler 2 wint beurt {0}", Beurt);
            }
            else if (winner == 0)
            {
                Gelijkspel++;
                winnerString = String.Format("Gelijkspel voor beurt {0}", Beurt);
            }
            else
            {
                throw new Exception("SelecteerWinnaar didn't give a proper response.");
            }

            // Telt het aantal beurten
            this.Beurt++;

            // Schrijft alleen naar de console als UpdateConsole true aangeeft. Om flikkerende beelden te vermijden. 
            if (UpdateConsole())
            {
                Console.Clear();
                Console.WriteLine(winnerString);
                Scores();
            }
        }

        private bool UpdateConsole()
        {
            if(DateTime.Now.Subtract(Time).Seconds > 1)
            {
                this.Time = DateTime.Now;
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
            else if ((P1 == 1 && P2 == 2) || (P1 == 2 && P2 == 3) || (P1 == 3 && P2 == 1))
            {
                return 2;
            }
            else
            {
                throw new Exception("SelecteerWinnaar doet niet wat het moet doen.");
            }
        }
    }
}
