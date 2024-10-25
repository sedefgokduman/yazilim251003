using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yazilim251003
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("bir sayı girin");
            int sayi = Convert.ToInt32(Console.ReadLine());
            if (sayi>0)
            {
                Console.WriteLine("pozitif sayı");
            }
            else if (sayi==0)
            {
                Console.WriteLine("sayı 0");
            }
            else
            {
                Console.WriteLine("negatif sayı");
            }
            Console.ReadKey();
        }
    }
}
