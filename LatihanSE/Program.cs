using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using foobar;


   class Program
    {
        static void Main()
        {
            Console.WriteLine("Masukkan angka yang ingin ditampilkan:");
            var angka = Console.ReadLine();
            foobar(int.Parse(angka));
            Console.ReadLine();
        }

       
    
}