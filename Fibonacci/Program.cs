using System;
using System.Linq;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {

            Fibonacci(20);
            

        }

        static void Fibonacci(int len) 
        {
            int a = 0, b = 1, c = 0;
            
            Console.WriteLine(a);
            Console.WriteLine(b);
            
            for (int i = 1; i < len; i++)
            {
                c = a + b;
                Console.WriteLine(c);
                a = b;
                b = c;

            }
            
        }

        static int Topla(params int[] sayilar )
        { 
            return sayilar.Sum();
        }


    }
}
