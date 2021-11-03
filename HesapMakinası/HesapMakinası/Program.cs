using System;

namespace HesapMakinası
{
    class Program
    {
        static void Main(string[] args)
        {

            int islem, sayi1, sayi2, sonuc;

            Console.WriteLine("Yapmak istediğiniz işlem için 1. sayıyı giriniz : ");
            sayi1 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Yapmak istediğiniz işlemi seçiniz (Toplama(+) = 1 , Çıkarma(-) = 2 , Çarpma(*) = 3 , Bölme(/) = 4): ");
            islem = Convert.ToInt16(Console.ReadLine());
            
            Console.WriteLine("Yapmak istediğiniz işlem için 2. sayıyı giriniz : ");
            sayi2 = Convert.ToInt16(Console.ReadLine());

            if (islem == 1)
            {
                sonuc = sayi1 + sayi2;
                Console.WriteLine(sonuc);
            }
            else if(islem == 2)
            {
                sonuc = sayi1 - sayi2;
                Console.WriteLine(sonuc);
            }
            else if (islem == 3)
            {
                sonuc = (sayi1 * sayi2);
                Console.WriteLine(sonuc);
            }
            else if (islem == 4)
            {
                sonuc = (sayi1 / sayi2);
                Console.WriteLine(sonuc);
            }
            else
            {
                Console.WriteLine("!!!Yanlış işlem seçtiniz!!!");
            }
        }
    }
}
