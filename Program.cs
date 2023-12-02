using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadnie_1_po_lekcji_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę:  ");
            int a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Podaj liczbę:  ");
            int b = Int32.Parse(Console.ReadLine());

            /*
            int a = 5;
            int b = 5;
            Console.WriteLine("Liczba a = 5");
            Console.ReadLine();
            Console.WriteLine("Liczba b = 5");
            Console.ReadLine();
            if (a == b)
            {
                Console.WriteLine("Liczby są sobie równe");
                Console.ReadLine();
            }*/

            if (a == b)
            {
                
                Console.WriteLine("Liczby są sobie równe");
                Console.ReadLine();
            }
            if (b != a) 
            { 
            
                Console.WriteLine("Liczby nie są sobie równe");
                Console.ReadLine();
            }
        }
    }
}
