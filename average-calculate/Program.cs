using System;
using System.Collections;

namespace average_calculate
{
    class Program
    {
        static void Main(string[] args)
        {
            Process process = new Process();

            Console.Write("Ortalama alınacak sayı miktarını giriniz:");
            int count = Convert.ToInt32(Console.ReadLine());
            int sum = 0;

            for(var i=0; i<count; i++)
            {
                sum += process.fibonacci_calculator(i);
            }

            Console.Write("Sonuç:");
            Console.WriteLine(sum/2);
            Console.ReadKey();
        }
    }
    class Process
    {
        public int fibonacci_calculator(int index)
        {
            if(index == 0)
            {
                return 0;
            }
            else if(index == 1)
            {
                return 1;
            }
            else
            {
                return fibonacci_calculator(index-1) + fibonacci_calculator(index-2);
            }
        }
    }
}
