using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ekrem Güngör
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Ekrem";
            musteri1.SoyAdi = "Güngör";
            musteri1.TcNo = "1653213256";


            //KODLAMA.İO
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "1562";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "1234567890";


            //Gerçek müşteri - Tüzel müşteri
            //SOLID

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(musteri1);
            customerManager.Add(musteri2);
        }
    }
}
