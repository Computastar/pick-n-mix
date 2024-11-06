using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace pick_n_mix
{
    public class Car
    {
        public string Colour { get; set; }

        public static void carColour(string colour)
        { 
            Console.WriteLine("The car colour is : " + colour);
        }

    }
}
