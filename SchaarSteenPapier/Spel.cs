using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchaarSteenPapier
{
    public class Spel
    {
        private Speler playerOneValue;

        public Speler PlayerOne
        {
            get { return playerOneValue; }
            set { playerOneValue = value; }
        }

        private Speler playerTwoValue;

        public Speler PlayerTwo
        {
            get { return playerTwoValue; }
            set { playerTwoValue = value; }
        }

        public Spel(Speler een, Speler twee)
        {
            this.PlayerOne = een;
            this.PlayerTwo = twee;

        }
    }
}
