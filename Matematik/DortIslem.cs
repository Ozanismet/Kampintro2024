﻿ using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematik
{
    internal class DortIslem
    {
        public void Topla(int sayi1, int sayi2)
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine("Sonuç: " + sonuc);
        }
        public void Cikarma(int sayi1,int sayi2)
        {
            int cikti = sayi1 - sayi2;
            Console.WriteLine("Sonuç: "+ cikti);
        }
    }
}
