


using Metotlar;
using System;

Product product1 =new Product();
product1.UrunAdi = "TELEFON";
product1.Fiyati = 45.000;
product1.Aciklama = "IPHONE 14 PRO MAX";

Product product2 = new Product();
product2.UrunAdi = "TELEFON";
product2.Fiyati = 35.000;
product2.Aciklama = "IPHONE 13 PRO";

Product product3 = new Product();
product3.UrunAdi = "TELEFON";
product3.Fiyati = 25.000;
product3.Aciklama = "IPHONE 11";

Product[] products = new Product[] {product1, product2, product3};

foreach (Product product in products)
{
    Console.WriteLine(product.Aciklama);
    Console.WriteLine(product.Fiyati+".000 TL");
    Console.WriteLine("-----------------------------------");
}
Console.WriteLine( "---------------------------------------METOTLAR------------------------------------------");

SepetManager sepetManager = new SepetManager();
sepetManager.Ekle(product1);
sepetManager.Ekle(product2);
sepetManager.Ekle(product3);
Console.WriteLine("-----------------------------------------------------------------------");
sepetManager.Ekle2("Muz", " Antalya Muzu", 50);
sepetManager.Ekle2("Çilek", "Trakya Çileği", 35);

