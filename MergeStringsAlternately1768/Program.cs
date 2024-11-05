namespace MergeStringsAlternately1768
{
    internal class Program
    {
        public string MergeAlternately(string word1, string word2)
        {
            string MergedWord = "";
            int pointer = 0 , x = word1.Length, y = word2.Length;

            while(pointer < x || pointer < y)
            {
                if (pointer < x)
                    MergedWord += word1[pointer];
                if (pointer < y)
                    MergedWord += word2[pointer];
                
                pointer++;
            }
            return MergedWord;
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
