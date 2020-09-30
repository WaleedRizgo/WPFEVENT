using System;
using System.Collections.Generic;
using System.Text;

namespace Switch
{
    public class Switch_Classe
    {
        public static void switch_Function()
        {
            Console.Write("Enter your number: ");
            int num = int.Parse(Console.ReadLine());
            switch (num)
            {
                case 1:
                case 2:
                    Console.WriteLine("One");
                    break;
                default:
                    Console.WriteLine("Other");
                    break;
            }
            Console.ReadKey();
        }
    }
}

