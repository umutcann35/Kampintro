using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sehirler = new string[] { "Ankara", "İstanbul", "İzmir", "Bursa" };

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(sehirler[i]); 

            }
            foreach (string sehir in sehirler)
            {
                Console.WriteLine(sehir);
            }
        }
    }
}
