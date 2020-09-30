using System;
using System.Collections.Generic;
using System.Text;

namespace Switch
{
    public class Try_Catch_Class
    {
        private static string strYN;
        public static void Try_Catch_Function()
        {

            do
            {
                try
                {
                    Console.Write("Enter Number 1: ");
                    int Number1 = int.Parse(Console.ReadLine());
                    Console.Write("Enter Number 2: ");
                    int Number2 = int.Parse(Console.ReadLine());
                    int r = Number1 / Number2;
                    Console.WriteLine("The Result: " + r);
                    Console.WriteLine("========================");
                    string[] strNames = new string[2];
                    strNames[0] = "Amr";
                    Console.WriteLine("Array is: " + strNames[0]);
                    Console.WriteLine("========================");

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.WriteLine("Ich bin Stark");
                    Console.WriteLine("========================");
                }
                Console.Write("Do you want to try more (Y/N): ");
                strYN = Console.ReadLine();
            } while (strYN == "y" || strYN == "Y");
        }
    }
}
