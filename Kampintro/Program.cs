using System;

namespace Kampintro
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmİsMİ = false;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun > dolarBugun) ;
            {
                Console.WriteLine("Azalıs oku");
            }
            else if (dolarDun < dolarBugun) ;
            {
                Console.WriteLine("artıs oku");
            }
            else
            {
                Console.WriteLine("degismedi");
            }
            
            if (sistemeGirisYapmİsMİ == true)
            {
                Console.WriteLine("Kullanici Ayarlari Butonu");
            }
            else
            {
                Console.WriteLine("Giris Yapınız");
            }

            Console.WriteLine(kategoriEtiketi);
        }
    }
}
