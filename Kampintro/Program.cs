using System; 

namespace Kampintro
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategorietiketi = "KATEGORİ";
            int sayi1 = 35248;
            double dolardun = 34.50;
            double dolarbugun = 34.50 ;

            if (dolardun > dolarbugun)
            {
                Console.WriteLine("Dolar Düştü");
            }
            else if (dolardun < dolarbugun)
            {
                Console.WriteLine("Dolar Arttı");

            }
            else
            {
                Console.WriteLine("Dolar Aynı");
            }


           
        }
    }
}