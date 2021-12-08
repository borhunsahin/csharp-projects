using System;

namespace draw_triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int dimension = Convert.ToInt32(Console.ReadLine());
            

            string triangle = "";

            for(var i=0; i<dimension; i++)
            {
                triangle += "#";
                Console.WriteLine(triangle);
            }

            Console.ReadLine();

        }
    }
}
