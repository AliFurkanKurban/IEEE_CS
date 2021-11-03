using System;
using System.Linq;
using static System.Math;

namespace Homeworks2
{
    class Program
    {
        static void Main(string[] args)
        {
            TekMiCiftMi(46);

            Console.WriteLine("*******************************************");

            Console.WriteLine(Cevir(75));

            Console.WriteLine("*******************************************");

            int[] dizi = {5,4,98,74,12,365,85};
            EnBuyukSayiyiBul(dizi);

            Console.WriteLine("*******************************************");

            AskerlikSorgula("Erkek",18);

        }

        private static void TekMiCiftMi(int sayi)
        {

            if (sayi % 2 == 0)
            {
                Console.WriteLine("{0} sayisi çifttir", sayi);
            }
            else
            {
                Console.WriteLine("{0} sayisi tektir", sayi);
            }
        }

        private static double Cevir(double sayi)
        {
            double sonuc = (5 * sayi / 100);
            return sonuc;
        }

        private static void EnBuyukSayiyiBul(int[] sayilar)
        {
            int buyukSayi = 0;
            for (int i = 0; i < sayilar.Length; i++)
            {
                if (sayilar[i] >= buyukSayi)
                {
                    buyukSayi = sayilar[i];    
                }
                else
                {
                    buyukSayi = buyukSayi;
                }
            }
            Console.WriteLine("En büyük sayı {0}", buyukSayi);
        }
        private static void AskerlikSorgula(string cinsiyet, int yas)
        { 
            if (cinsiyet == "Erkek" || cinsiyet == "erkek")
            {
                if (yas > 20)
                {
                    Console.WriteLine("Askerlik yoklamasına tabiisiniz");
                }
                else
                {
                    Console.WriteLine("Askerlik ile ilişiği yoktur");
                }

            }
            else
            {
                Console.WriteLine("Askerlik ile ilişiği yoktur");
            }
        }




        private static int Topla(params int[] sayilar1) 
        {
            return sayilar1.Sum();
        }
        private static void UsAl(int sayi1, int üsSayi)
        {
            var usSonuc = Math.Pow(sayi1, üsSayi);
            Console.WriteLine(usSonuc);
        }
        private static void KareKokAl(double sayi1)
        {
            double kareKokSonuc = Math.Sqrt(sayi1);
            Console.WriteLine(kareKokSonuc);
        }
    }
}
