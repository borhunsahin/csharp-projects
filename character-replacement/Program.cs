using System;

namespace character_reserve_print
{
    class Program
    {
        static void Main(string[] args)
        {
            Process process = new Process();

            string sentence = "Merhaba Hello Algoritma x";

            string[] list = sentence.Split();
                
            int counter = 0;
            foreach (var word in list)
            {
                if(word.Length>2)
                {
                    list[counter] = process.reverser(word);
                    counter++;
                }
                else
                {
                    counter++;
                }  
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
            string newword = "";

            char temp1 = word[0];
            char temp2 = word[word.Length-1];
         
            word = word.Substring(1,word.Length-2);     
            

            newword += temp2+word+temp1;


            return newword;
        }
    }
}
