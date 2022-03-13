using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ogretmen merve=new Merve();
            Ogretmen yakup = new Yakup();
            Ogrenci[] ogrencis=new Ogrenci[2];

            foreach (var item in ogrencis)
            {
                item.Yaz();
            }
            Console.Read();
        }
    }
    abstract class Ogrenci
    {
        abstract public void Yaz();
    }
    abstract class Ogretmen
    {
        abstract public void Sor();
    }
    class Yalçın : Ogrenci
    {
        public override void Yaz()
        {
            Console.WriteLine("Ben yazıyorum... Yalçın...");
        }
    }
    class Bilgovski : Ogrenci
    {
        public override void Yaz()
        {
            Console.WriteLine("Ben yazdım bile hep öndeyim Ezik... Bilgovski..");
        }
    }
    class Yakup : Ogretmen
    {
        public override void Sor()
        {
            Console.WriteLine("Arkadaşlar bitti mi Geçiyorum.. Yakup...");
        }
    }
    class Merve : Ogretmen
    {
        public override void Sor()
        {
            Console.WriteLine("Yazdınız mı şekerler?? Mervoski..");
        }
    }
}
