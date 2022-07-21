using System;

namespace ClassIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Adi = "Engin";
            int yas = 36;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Kerem Varış";
            kurs2.IzlenmeOrani = 64;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.Egitmen = "Berkay Bilgin";
            kurs3.IzlenmeOrani = 80;

            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = "C#";
            kurs4.Egitmen = "Ahmet Burak";
            kurs4.IzlenmeOrani = 100;

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3, kurs4 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmen);
            }

            Urun urun1 = new Urun();
            urun1.UrunAdi = "Basketbol Topu";
            urun1.Markasi = "TARMAK";
            urun1.Fiyat = 49.90;

            Urun urun2 = new Urun();
            urun2.UrunAdi = "Tenis Topu";
            urun2.Markasi = "Unknown";
            urun2.Fiyat = 89.90;

            Urun urun3 = new Urun();
            urun3.UrunAdi = "Futbol Topu";
            urun3.Markasi = "Nike";
            urun3.Fiyat = 349.90;

            Urun[] urunler = new Urun[] {urun1, urun2, urun3 };

            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.UrunAdi + " : " + urun.Fiyat);
            }
        }

        class Kurs
        {
            public string KursAdi { get; set; }
            public string Egitmen { get; set; }
            public int IzlenmeOrani { get; set; }

        }

        class Urun
        {
            public string UrunAdi { get; set; }
            public string Markasi { get; set; }
            public double Fiyat { get; set; }

        }
    }
}
