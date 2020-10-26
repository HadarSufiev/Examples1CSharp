using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex3
{
    public class MethodSamples
    {

        public static void operations(int a, int b, out int c, out int d)
        {
            c = a + b;
            d = a * b;
        }

        public static void inc(int i)
        {
            i++;
        }

        public static void incRef(ref int i)
        {
            i++;
        }

        public static void addNumbers(out int sum, params int[] val)
        {
            sum = 0;
            foreach (int i in val)
            {
                sum += i;
            }
        }


        public static void Main()
        {
            int x = 10;
            // pass x by value
            inc(x);
            Console.WriteLine("The value of x after inc {0}", x);
            // pass x by reference
            incRef(ref x);
            Console.WriteLine("The value of x after incRef {0}", x);

            // using out parameters
            int a = 3, b = 4, c, d;
            operations(a, b, out c, out d);
            Console.WriteLine("The sum of {0} and {1} is {2}, their multiplication is {3}", a, b, c, d);

            // using variable number of parameters
            int sum;
            addNumbers(out sum, 2, 4, 6, 2);
            Console.WriteLine("The sum of the numbers is {0}", sum);
            Console.ReadLine();
        }

    }
}
