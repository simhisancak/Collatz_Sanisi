using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
namespace Collatz_Sanısı
{
    class Program
    {
        static void Main(string[] args)
        {
        basadon:
            string s = "";
            Console.Clear();
            Console.WriteLine("Döngü İçin 1 - Sayı İçin 2");
            s = Console.ReadLine();
            if (s == "1")
            {
                sayi.dongu();
            }
            else if (s == "2")
            {
                sayi.collatz();
            }
            GC.Collect();
            Console.WriteLine("-------------bitti-----------");
            Console.WriteLine();
            Console.WriteLine("Başa Dönmek İçin Herhangi Bir Tuşa Bas veya Çıkmak İçin ESC Tuşuna Bas");
            while (true)
            {
                if (Console.ReadKey(true).Key == ConsoleKey.Escape)
                {
                    break;
                }
                else
                {
                    goto basadon;
                }
            }
        }//main
    }//class
}//collatz
