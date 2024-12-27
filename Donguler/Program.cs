

string[] Dilkurslari = new string[] {"Almanca", "İngilizce", "Fransızca","Japonca", "Türkçe","İspanyolca"}; 


for (int i = 0; i< Dilkurslari.Length; i++)      // DAHA GENEL AMAÇLAR İÇİN KULLANILIR.
{
    Console.WriteLine(Dilkurslari[i]);
}

Console.WriteLine("--------------------------------------------------------------------------------");


foreach (string kurs in Dilkurslari)            // DİZİLERİ DAHA KOLAY DOLAŞMAK İÇİN KULLANIRIZ.
{
    Console.WriteLine(kurs);
}
Console.WriteLine("--------------------------------------------------------------------");


Kurs kurs1= new Kurs();
kurs1.EgitmenAdi = "Ozan ALYÖRÜK";
kurs1.KursAdi = "C#";
kurs1.IzlenmeOrani = 80;
Console.WriteLine("Kurs Adı: " + kurs1.KursAdi + "   "+"Eğitmen Bilgileri:  " + kurs1.EgitmenAdi+ "   "+"İzlenme:  " + kurs1.IzlenmeOrani);

Kurs kurs2 = new Kurs();
kurs2.EgitmenAdi = "Engin Demiroğ";
kurs2.KursAdi = ".Net";
kurs2.IzlenmeOrani = 40;

Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");

//Console.WriteLine("Kurs Adı: " + kurs1.KursAdi + "   " +"Eğitmen Bilgileri:  " + kurs1.EgitmenAdi + "   " + "İzlenme:  " + kurs1.IzlenmeOrani);

Kurs[] kurslar = new Kurs[] {kurs1, kurs2};   // BURADA Kurs SINIFI İÇERİSİNDE FARKLI VE BİRDEN FAZLA DEĞİŞKENLER TUTARAK ONU ARRAY (DİZİLER) KULLANARAK TEK TEK DÖNÜYORUZ KURSLARI

foreach (var kurs in kurslar)
{
    Console.WriteLine("Aktif Kurslar :  "+ kurs.KursAdi);   // DÖNGÜ İLE ELİMİZDE Kİ KURS SINIFINI DÖNEREK EKRANA YAZDIRMAMIZI İSTEDİĞİMİZ ALANI YAZDIRIYORUZ.  
}


class Kurs
{
    public string KursAdi { get; set; }
    public string EgitmenAdi { get; set; }
    public int IzlenmeOrani { get; set; }

}