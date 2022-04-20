using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";

            Urun[] urunler = new Urun[] 
            {  
                urun1,urun2
            
            };
            //type-safe -- tip güvenli
            foreach (Urun urun in urunler)
            {

                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("------------------");

            }

            Console.WriteLine("-------------METOTLAR--------------");
            //instance - örnek
            //encapsulation

            SepetNamager sepetNamager = new SepetNamager();
            sepetNamager.Ekle(urun1);
            sepetNamager.Ekle(urun2);

            sepetNamager.Ekle2("Armut", "Yeşil armut", 12, 10);
            sepetNamager.Ekle2("Elma", "Yeşil armut", 10, 9);
            sepetNamager.Ekle2("Karpuz", "Diyarbakır karpuzu", 40, 8);

        }
    }
}


//Dont repeat yourself - DRY = Kendini tekrar etme - Clean Code - Best Practice


