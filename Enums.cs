using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POCs
{
    internal class Enums
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine($"{Seasons.Earth} is {(int)Seasons.Earth} planet in the Solar system");

            Console.WriteLine($"{(Seasons)3} is {(int)(Seasons)3} planet in the Solar system");
        }

        enum Seasons
        {//has numbering like arrays 0,1,2,3,4 and auto increments,so
            Mercury = 1, // 1
            Venus,       // 2
            Earth,      // 3 and so on
            Mars,
            Jupiter ,
            Saturn,
            Uranus,
            Neptune
        }
    }
}
