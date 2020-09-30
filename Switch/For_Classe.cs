using System;
using System.Collections.Generic;
using System.Text;

namespace Switch
{
    public class For_Classe
    {
        public static void for_Function()
        {
            Console.Write("Enter Your Num: ");
            int basenum = int.Parse(Console.ReadLine());
            for (int x = 1; x < 10; x++)
            {
                Console.WriteLine(basenum + "*" + x + "=" + basenum * x);
            }
        }
    }
}
