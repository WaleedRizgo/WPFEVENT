using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;


namespace Switch
{
    public class Regex_Classe
    {
        private static string strYN;
        public static void regex_Function()
        {
            //Regex reg = new Regex("^\\d{3}$");
            do
            { //Regex reg = new Regex("^\\d{3} - \\d{7-10}$");
                Regex reg = new Regex("^[A-Z][a-z]+$");

                Console.Write("Write your Name: ");
                string _text = Console.ReadLine();
                if (reg.IsMatch(_text))
                {
                    Console.WriteLine("Correct Name");
                }
                else
                {
                    Console.WriteLine("Invalid Name");

                }
                Console.WriteLine("==============================");
                Console.Write("Do you want to test othe Name (Y/N): ");
                strYN = Console.ReadLine();
                Console.WriteLine("==============================");
            } while (strYN == "y" || strYN == "Y");

            Console.ReadKey();
        }
    }
}
