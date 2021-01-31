using System;
using System.Collections.Generic;
using System.Text;

namespace ArgumentNullException
{
    class Master2
    {
        static void Main(string[] args)
        {
            string SourceName = "itstep.org";
            string UserName = "";
            try
            {
                UserName = Console.ReadLine();
                if (SourceName != UserName)
                {
                    throw new Exception("Сервер не отвечает!");
                }
                else
                    Console.WriteLine("Correct\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();

            int[] arr = new int[5];
            Random rand = new Random();
            for (int i = 0; i < 5; i++)
            {
                arr[i] = rand.Next(1, 10);
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine("\n");
            try
            {
                for (int i = 0; i < 6; i++)
                {
                    Console.WriteLine(arr[i]);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }

}