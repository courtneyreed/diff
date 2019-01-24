using System;
using System.IO;

namespace Diff_ing
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("sr-sample-input.txt");

            //string strA = line.;
            //string strB = ;

            foreach (string line in lines)
            {
                int length = line.Length;
                //Console.WriteLine(line.Length);

                string[] words = line.Split(' ');
                foreach (var word in words)
                {
                    //if (strA.Contains(word))
                    Console.WriteLine($"{word}");
                }
            }
        }
    }
}
