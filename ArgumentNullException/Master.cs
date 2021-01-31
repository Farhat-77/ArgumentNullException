using System;
using System.Collections.Generic;
using System.Text;

namespace ArgumentNullException
{
    public class Master
    {
        static void Main()
        {
            int[] values = { 10, 7 };
            foreach (var value in values)
            {
                try
                {
                    Console.WriteLine("{0} divided by 2 is {1}", value, DivideByTwo(value));
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine("{0}: {1}", e.GetType().Name, e.Message);
                }
                Console.WriteLine();
            }
        }
        static int DivideByTwo(int num)
        {
            if ((num & 1) == 1)
                throw new ArgumentException(String.Format("{0} is not an even number", num),
                                          "num");
            return num / 2;
        }
    }
}
