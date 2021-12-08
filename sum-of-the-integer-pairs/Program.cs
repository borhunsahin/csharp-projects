using System;
using System.Collections.Generic;

namespace sum_of_the_integer_pairs
{
    class Program
    {
        static void Main(string[] args)
        {
            Process process = new Process();
            List<int> integers = new List<int>();
            
            Console.Write("Lütfen kaç adet sayı gireceğinizi belirleyiniz");
            string choice = Console.ReadLine();
            

            if(Convert.ToInt32(choice) % 2 == 0)
            {
                for(var i = 0; i<Convert.ToInt32(choice)/2;i++)
                {
                    int num1 = Convert.ToInt32(Console.ReadLine());
                    int num2 = Convert.ToInt32(Console.ReadLine());
                    
                    if(process.check(num1,num2)==false)
                    {
                        integers.Add(process.sum(num1,num2));
                    }
                    else
                    {
                        
                    }
                }
            }
            else
            {
                Console.WriteLine("Lütfen çift sayı giriniz!");         
            }
                
            foreach(var num in integers)
            {
                Console.WriteLine(num);
                
            }
            Console.ReadLine();
            
        }
    }
    class Process
    {
        public Boolean check(int num1, int num2)
        {
            return num1 == num2;
        }
        public int sum(int num1, int num2)
        {
            return num1 + num2;
        }
        public double exponentiate(int num1,int num2)
        {
            return Math.Pow(num1,num2);
        }
    }
}
