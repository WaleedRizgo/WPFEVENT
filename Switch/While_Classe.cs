using System;
using System.Collections.Generic;
using System.Text;

namespace Switch
{
    public class While_Classe
    {
        private static string strYN;

        public static void while_Function()
        {
            do
            {
                Console.Write("Enter Number 1: ");
                int Number1 = int.Parse(Console.ReadLine());
                Console.Write("Enter Number 2: ");
                int Number2 = int.Parse(Console.ReadLine());
                int Result = Number1 + Number2;
                Console.WriteLine("The sum result is: " + Result);
                Console.WriteLine("==============================");
                Console.Write("Do you want to add other Numbers (Y/N): ");
                strYN = Console.ReadLine();
                Console.WriteLine("==============================");
            } while (strYN == "y" || strYN == "Y");
        }
    }
}
