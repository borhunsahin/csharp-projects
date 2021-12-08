using System;

namespace absolute_squaring
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Lütfen yazılacak sayı adedini giriniz: ");
            int n = Convert.ToInt32(Console.ReadLine());
            
            int diff = 0;
            int sum = 0;

            for(var i=0; i<n; i++)
            {
                int num = Convert.ToInt32(Console.ReadLine());

                if(num<67)
                {
                    diff += 67-num;
                }
                else
                {
                    sum += (num-67)*(num-67);
                }
            }

            Console.WriteLine(diff+" "+sum);
            Console.ReadLine();
        }
    }
}
