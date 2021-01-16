using System;

namespace Classİntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "c#";
            kurs1.Egitmeni = "engin";

                
        }
    }


    class Kurs
    {
        public string KursAdi { get; set; }

        public string Egitmeni { get; set; }


    }
}
