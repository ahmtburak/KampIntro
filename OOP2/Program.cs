using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "1234";
            musteri1.Adi = "Engin";
            musteri1.SoyAdi = "Demiroğ";
            musteri1.TcNo = "123131";

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "541234";
            musteri2.SirketAdi = "Kodlama.i";
            musteri2.VergiNo = "12312312";

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);



            // Gerçek Müşteri - Tüzel Müşteri   
        }
    }
}
