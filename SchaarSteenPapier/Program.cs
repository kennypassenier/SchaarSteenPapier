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
            int aantalBeurten = 100;
            while (aantalBeurten > 0)
            {
                Console.WriteLine(aantalBeurten);
                --aantalBeurten;
            }                        
        }
    }
}
