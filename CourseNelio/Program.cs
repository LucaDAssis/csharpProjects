using System;
using System.Threading.Channels;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args) {

            sbyte numero = 120;

            byte n1 = 255;
            n1 ++;
            Console.WriteLine(n1);

            int n2 = 10000;
            Console.WriteLine(n2);
            
            long n3 = 9223;

            Console.WriteLine(n3);

           
            for (int i = 0; i < numero; i+=10)
            {
                Console.WriteLine("Isso" + numero + i);
                
            }

            
            
        }
    }
}