using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FooBar
{
   class FooBar
    {
        static void Main()
        {
            Console.WriteLine("Masukkan angka yang ingin ditampilkan:");
            var angka = Console.ReadLine();
            foobar(int.Parse(angka));
            Console.ReadLine();
        }

        private static int dibagi3(int n)
        {
            var bagiTiga = n%3;
            return bagiTiga;
        }

        public static int dibagi5(int n)
        {
            var bagiLima = n%5;
            return bagiLima;
        }

        public static void foobar(int angka)
        {
            for(var n = 1; n <= angka; n++)
            {
                
                var bisaDibagi = false;

                if (dibagi3(n) == 0)
                {
                    Console.Write("foo");
                    bisaDibagi = true;
                }

                if (dibagi5(n) == 0)
                {
                    Console.Write("bar");
                    bisaDibagi = true;
                }
                    
                if (bisaDibagi)
                    Console.WriteLine();
                else
                    Console.WriteLine(n);
            }
        }
    }
}