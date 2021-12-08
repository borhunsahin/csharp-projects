using System;

namespace character_reserve_print
{
    class Program
    {
        static void Main(string[] args)
        {
            Process process = new Process();

            string sentence = "Merhaba Hello Question";

            string[] list = sentence.Split();
                
            int counter = 0;
            foreach (var word in list)
            {
                list[counter] = process.reverser(word);
                counter++;
            }

            foreach (var word in list)
            {
                Console.Write(word+" ");
            }
            Console.ReadLine();
        }
    }
    class Process
    {
        public string reverser(string word)
        {
            char temp = word[0];
            string newword = word.Remove(0,1);
            newword += word[0];

            return newword;
        }
    }
}
