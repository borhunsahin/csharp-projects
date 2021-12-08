using System;

namespace consonant_letter
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = "Merhaba Umut Arya";
            string[] words = sentence.Split(" ");

            string[] vowels = {"a","e","ı","i","o","ö","u","ü"};

            

            for(var i=0; i<words.Length; i++)
            {
                

                for(var j=0; j<words[j].Length; j++)
                {
                    bool check=false;

                    if()
                    {
                        check=true;
                    }
                    
                    Console.WriteLine(check);
                }
            }
            Console.ReadLine();

            
        }
    }
}
