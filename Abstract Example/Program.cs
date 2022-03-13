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
            Ogretmen aslı=new Aslı();
            Ogretmen selim = new Selim();
            Ogrenci yalcin=new Yalcin();
            Ogrenci elif =new Elif();
            aslı.Sor();
            selim.Sor();
            elif.Yaz();
            yalcin.Yaz();

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
    class Yalcin : Ogrenci
    {
        public override void Yaz()
        {
            Console.WriteLine("Ben yazıyorum...");
        }
    }
    class Elif : Ogrenci
    {
        public override void Yaz()
        {
            Console.WriteLine("Ben yazdım bile...");
        }
    }
    class Selim : Ogretmen
    {
        public override void Sor()
        {
            Console.WriteLine("Arkadaşlar bitti mi Geçiyorum..");
        }
    }
    class Aslı : Ogretmen
    {
        public override void Sor()
        {
            Console.WriteLine("Yazdınız mı arkadaşlar??");
        }
    }
}
