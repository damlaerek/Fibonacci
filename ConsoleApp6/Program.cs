using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        public static double PositiveFibonacci(double n)
        {
            int donus = Convert.ToInt32(n);
        
            int number = donus; 
            int[] Fib = new int[donus + 1];
            Fib[0] = 0;
            Fib[1] = 1;
            for (int i = 2; i <= donus; i++)
            {
                Fib[i] = Fib[i - 2] + Fib[i - 1];
            }
            int end = Fib[donus];
            double end1 = Convert.ToDouble(end);
            return end1;


        }
        public static double NegativeFibonacci(double n)
        {
            int donus = Convert.ToInt32(n);
           
            int number1 = donus * -1;
            int[] Fibn = new int[number1 + 1];

            Fibn[0] = 0;
            Fibn[1] = 1;

            for (int i = 2; i <= number1; i++)
            {
                int a = Convert.ToInt32(PositiveFibonacci(i));
                int b = Convert.ToInt32(Math.Pow(-1, n + 1));
                Fibn[i] = a * b;
            }
            int end = Fibn[number1];
            double end1 = Convert.ToDouble(end);
            return end1;

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Kaç sayi girmek istiyorsunuz");
            double sayi = Convert.ToDouble(Console.ReadLine());
            
            Double[] list = new Double[1000000];
            for (int i = 0; i < sayi; i++)
            {
                Console.WriteLine("Please enter a number");
                list[i] = Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine("Sonuçlar");

            for (int j = 0; j < sayi; j++)
            {
                if (list[j] > 0)
                {
                    Console.WriteLine(PositiveFibonacci(list[j]));
                }

                if (list[j] <= 0)
                {
                    Console.WriteLine(NegativeFibonacci(list[j]));
                }
                
            }
            Console.ReadLine();


        }
    }
}
