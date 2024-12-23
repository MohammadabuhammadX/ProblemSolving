﻿using System.Text;

namespace MergeStringsAlternately1768
{
    internal class Program
    {
        public string MergeAlternately(string word1, string word2)
        {
            //string MergedWord = "";
            //int pointer = 0 , x = word1.Length, y = word2.Length;

            //while(pointer < x || pointer < y)
            //{
            //    if (pointer < x)
            //        MergedWord += word1[pointer];
            //    if (pointer < y)
            //        MergedWord += word2[pointer];

            //    pointer++;
            //}
            //return MergedWord;
            //int maxLength = Math.Max(word1.Length, word2.Length);
            //char[] merged = new char[word1.Length + word2.Length];

            //int k = 0;

            //for (int i = 0; i < maxLength; i++)
            //{
            //    if(i<word1.Length) merged[k++] = word1[i];
            //    if(i<word2.Length) merged[k++] = word2[i];
            //}
            //return new string (merged);
            var result = new StringBuilder();
            int maxLength = Math.Max(word1.Length, word2.Length);

            for (int i = 0; i < maxLength; i++)
            {
                if(i<word1.Length)
                {
                    result.Append(word1[i]);
                }
                if (i < word2.Length)
                {
                    result.Append(word2[i]);
                }
            }
            return result.ToString();
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            // input string

            string word1 = "ace";
            string word2 = "bdf";

            string result = program.MergeAlternately(word1, word2);

            Console.WriteLine(result);
        }
    }
}
