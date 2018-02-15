using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchaarSteenPapier
{
    class Speler
    {
        private string naamValue;

        public string Naam
        {
            get { return naamValue; }
            set { naamValue = value; }
        }

        public Speler(string naam)
        {
            this.Naam = naam;
        }

        public int SpeelBeurt()
        {
            return new Random(DateTime.Now.Millisecond).Next(1, 4);
        }

    }
}
