using System;
using System.Collections.Generic;

namespace algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            Process process = new Process();

            List<string> liste = new List<string>();

            liste.Add("Algoritma"); 
            liste.Add("0");

            Console.WriteLine(process.character_deleter(liste[0],Convert.ToInt32(liste[1])));
            Console.ReadLine();


        }
    }
    class Process
    {
        public string character_deleter(string word,int index)
        {
            if(index>word.Length || index<0)
            {
                return word;
            }
            else
            {
                return word.Remove(index,1);
            }       
        }
    }
}
