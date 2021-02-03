using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string gir1;
            string gir2;
            string eposta = "emir";
            string sifre = "123456";
            string sec;
            string islem1;
            string islem2;
            string islem3;
            string islem4;
            string sil;

            Console.Write("E-Postanızı Giriniz: ");
            gir1 = Console.ReadLine();
            Console.Write("Şifrenizi Giriniz: ");
            gir2 = Console.ReadLine();

            Musteri musteri1 = new Musteri();
            musteri1.MusteriID = "1";
            musteri1.MusteriAdi = "Emir";
            musteri1.MusteriSoyadi = "CANSIZ";
            musteri1.MTelefon = "5555555555";

            Musteri musteri2 = new Musteri();
            musteri2.MusteriID = "2";
            musteri2.MusteriAdi = "Mustafa";
            musteri2.MusteriSoyadi = "YILMAZ";
            musteri2.MTelefon = "4444444444";

            Musteri musteri3 = new Musteri();
            musteri3.MusteriID = "3";
            musteri3.MusteriAdi = "Furkan";
            musteri3.MusteriSoyadi = "TETİK";
            musteri3.MTelefon = "33333333333";

            Musteri musteri4 = new Musteri();
            musteri4.MusteriID = "4";
            musteri4.MusteriAdi = "Selman";
            musteri4.MusteriSoyadi = "KAYA";
            musteri4.MTelefon = "2222222222";

            if (gir1==eposta && gir2==sifre)
            {
                Console.WriteLine("----------------------------------------");
                Console.WriteLine(" ");
                Console.WriteLine("Giriş Başarılı");
                Console.WriteLine(" ");
                Console.WriteLine("----------------------------------------");
                Console.WriteLine(" ");

                MusteriManager musteriIslemleri = new MusteriManager();
                
                musteriIslemleri.List();
                
                Musteri[] listele1 = new Musteri[] { musteri1, musteri2, musteri3, musteri4 };
                
                foreach (var listele in listele1)
                {
                    Console.WriteLine(listele.MusteriID + " - " + listele.MusteriAdi + " " + listele.MusteriSoyadi + " - " + listele.MTelefon);
                    Console.WriteLine(" ");
                    Console.WriteLine("----------------------------------------");
                    Console.WriteLine(" ");
                }
                Console.WriteLine("MÜŞTERİ İŞLEMLERİ");
                Console.WriteLine(" ");
                Console.WriteLine("----------------------------------------");
                Console.WriteLine(" ");
                Console.WriteLine("1. Müşteri Ekle");
                Console.WriteLine(" ");
                Console.WriteLine("2. Müşteri Sil");
                Console.WriteLine(" ");
                Console.Write("Yapmak İstediğiniz İşlemin Numarasını Yazınız: ");
                sec = Console.ReadLine();
                switch (sec)
                {
                    case "1":
                        Console.Write("Sıra Numarasını Giriniz: ");
                        islem1 = Console.ReadLine();
                        Console.Write("İsmini Giriniz: ");
                        islem2 = Console.ReadLine();
                        Console.Write("Soyadını Giriniz: ");
                        islem3 = Console.ReadLine();
                        Console.Write("Telefon Numarasını Giriniz: ");
                        islem4 = Console.ReadLine();
                        musteriIslemleri.Add(islem1,islem2,islem3,islem4);
                        break;
                    case "2":
                        Console.WriteLine("Silmek İstediğiniz Müşterinin ID'sini Giriniz: ");
                        sil = Console.ReadLine();
                        musteriIslemleri.Delete();
                        break;
                    default:
                        break;
                }

            }
            else
            {
                Console.WriteLine("Kullanıcı adı veya şifre hatalı. Daha sonra tekrar deneyiniz.");
            }

        }
    }
}
