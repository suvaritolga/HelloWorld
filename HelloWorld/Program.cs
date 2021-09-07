using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello La");
            int toplam = SayilariTopla(5, 3);
            Console.WriteLine(toplam);
            Console.Read();


        }

        static int SayilariTopla(int sayi1,int sayi2)
        {
            return sayi1 + sayi2;
        }
    }
}
