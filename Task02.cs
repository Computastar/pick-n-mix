using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pick_n_mix
{
    internal class Task02
    {
        public static void Run()
        {
            // int to decimal
            int intValue = 2;
            decimal decimalValue = (decimal)intValue;
            Console.WriteLine("int to decimal: " + decimalValue);

            // decimal to double
            decimal decimalValue2 = 1.1m;
            double doubleValue = (double)decimalValue2;
            Console.WriteLine("decimal to double: " + doubleValue);

            // float to int
            float floatValue = 2.9f;
            int intValue2 = (int)floatValue;
            Console.WriteLine("float to int: " + intValue2);

            // double to float
            double doubleValue2 = 3.678908765436578;
            float floatValue3 = (float)doubleValue2;
            Console.WriteLine("double to float: " + floatValue3);

        }
    }
}
