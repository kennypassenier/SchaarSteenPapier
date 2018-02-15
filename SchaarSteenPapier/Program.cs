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
            // This is just to have something in the master branch
            Speler een = new Speler("Een");
            Speler twee = new Speler("Twee");
            for (int teller = 0; teller < 100; teller++)
            {
                Console.WriteLine("Een:");
                Console.WriteLine(een.SpeelBeurt());
                Console.WriteLine("Twee:");
                Console.WriteLine(twee.SpeelBeurt());
            }
        }
    }
}
