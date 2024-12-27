using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Metotlar
{
    internal class SepetManager
    {
        public void Ekle(Product product)
        {
            Console.WriteLine("Sepete Eklendi:  " + product.Aciklama);
        }

        public void Ekle2(string urunAdi, string Aciklama, double Fiyati)   // PRODUCT METHODU YAPMADAN BU ŞEKİLDE DE YAPILIR AMA TERCİH EDİLMEZ. 
        {
            Console.WriteLine("Sepete Eklendi: "+ urunAdi+ "  -------- " +Fiyati+ " TL");
        }
    }
}