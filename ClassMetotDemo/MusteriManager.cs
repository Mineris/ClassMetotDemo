using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Add(string id, string musteriAdi, string musteriSoyadi, string telefon)
        {
            Console.WriteLine(" ");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine(" ");
            Console.WriteLine("Kayıt Eklendi: " + musteriAdi+ " " +musteriSoyadi);
            Console.WriteLine(" ");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine(" ");
        }
        public void Delete()
        {
            Console.WriteLine(" ");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine(" ");
            Console.WriteLine("Kayıt Silindi");
            Console.WriteLine(" ");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine(" ");
        }
        public void List()
        {
            Console.WriteLine(" ");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine(" ");
            Console.WriteLine("Kayıt Listelendi");
            Console.WriteLine(" ");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine(" ");

        }
    }
}
