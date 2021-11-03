using System;

namespace GirisUygulaması
{
    class Program
    {
        static void Main(string[] args)
        {
            Validate("afk","12345");
            Validate("aksdhjads","asd545");    
        }

        static void Validate(string nickName, string paswword) 
        {
            if (nickName == "afk" && paswword == "12345")
            {
                Console.WriteLine("Başarıyla giriş yapıldı. ");
            }
            else
            {
                Console.WriteLine("Yanlış şifre veya parola lütfen tekrar deneyiniz !");
            }
        }
    }
}
