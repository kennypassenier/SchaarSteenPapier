﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchaarSteenPapier
{
    public class Speler
    {
        //// Geeft elke speler zijn eigen random seed
        //private Random randomInstanceValue;

        //public Random RandomInstance
        //{
        //    get { return randomInstanceValue; }
        //    set { randomInstanceValue = value; }
        //}
        
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
            //if(seed == 0)
            //{
            //    this.RandomInstance = new Random();
            //}
            //else
            //{
            //    this.RandomInstance = new Random(seed);
            //}
        }

        public int SpeelBeurt()
        {
            System.Threading.Thread.Sleep(02);
            int keuze = new Random(DateTime.Now.Millisecond).Next(1, 4);
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
            return string.Format("Speler: {0} \t Score: {1} \t Schaar: {2} \t Steen: {3} \t Papier: {4}", this.Naam, this.Score, this.Schaar, this.Steen, this.Papier);
        }

    }
}
