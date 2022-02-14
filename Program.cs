using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            string cumle;
            Console.Write("Bir cümle giriniz: ");
            cumle = Console.ReadLine();
            // bir strin ifadenin karakter sayısını Length 
            //Console.WriteLine(cumle.Length); 
            for (int i = 0; i < cumle.Length; i++)
            {
                Console.WriteLine(cumle[i]);
            }
            Console.ReadKey();
        }
    }
}
