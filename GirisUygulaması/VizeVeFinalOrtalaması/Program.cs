using System;

namespace VizeVeFinalOrtalaması
{
    class Program
    {
        static void Main(string[] args)
        {
            int vize, final;
            double sonuc;

            vize = 75;
            final = 60;
            sonuc = ((vize * 0.4) + (final * 0.6));

            Console.WriteLine("Vize Final Ortalaması : "+ sonuc);
        }
    }
}
