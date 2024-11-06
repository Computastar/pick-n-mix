using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pick_n_mix
{
    internal class Task05
    {
        public static void Run()
        {
            Console.Write("Input a int : ");
            string intInput = Console.ReadLine();
            int intValue;
            int.TryParse(intInput, out intValue);

            Console.Write("Input a decimal : ");
            string decimalInput = Console.ReadLine();
            decimal decimalValue;
            decimal.TryParse(decimalInput, out decimalValue);

            decimal divedBy = intValue / decimalValue;
            Console.WriteLine(divedBy);

            double doubleOutput = (double)divedBy;

            // Console.WriteLine("Result of division as double :  " + doubleOutput);

            Console.Write("Return the answer as Char array True/False:");
            string boolInput = Console.ReadLine();
            bool boolValue;
            bool.TryParse(boolInput, out boolValue);

            if (boolValue)
            {
                char[] charArray = doubleOutput.ToString().ToCharArray();
                Console.WriteLine("Result as car array : " + string.Join(", ", charArray));
            }
            else
            {
                Console.WriteLine("Result as a double : " + doubleOutput);
            }

        }
    }
}
