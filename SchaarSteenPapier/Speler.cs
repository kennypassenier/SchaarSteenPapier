using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchaarSteenPapier
{
    public class Speler
    {
        private string naamValue;

        public string Naam
        {
            get { return naamValue; }
            set { naamValue = value; }
        }

        private int scoreValue;

        public int Score
        {
            get { return scoreValue; }
            set { scoreValue = value; }
        }

        private int schaarValue;

        public int Schaar
        {
            get { return schaarValue; }
            set { schaarValue = value; }
        }

        private int steenValue;

        public int Steen
        {
            get { return steenValue; }
            set { steenValue = value; }
        }

        private int papierValue;

        public int Papier
        {
            get { return papierValue; }
            set { papierValue = value; }
        }
        
        public Speler(string naam, int seed = 0)
        {
            this.Naam = naam;
        }

        public int SpeelBeurt(Random RandomInstance)
        {            
            int keuze = RandomInstance.Next(1, 4);
            if(keuze == 1)
            {
                this.Schaar++;
            }
            else if(keuze == 2)
            {
                this.Steen++;
            }
            else if (keuze == 3)
            {
                this.Papier++;
            }
            else
            {
                throw new Exception("Fout bij het kiezen van een actie.");
            }
            return keuze;
        }

        public override string ToString()
        {
            return string.Format("Speler: {0} \t Score: {1:n0} \t Schaar: {2:n0} \t Steen: {3:n0} \t Papier: {4:n0}", this.Naam, this.Score, this.Schaar, this.Steen, this.Papier);
        }

    }
}
