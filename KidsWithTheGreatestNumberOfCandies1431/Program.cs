namespace KidsWithTheGreatestNumberOfCandies1431
{
    internal class Program
    {
        public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
        {
            int maxCandies = candies.Max();

            bool[] result =new bool[candies.Length];

            for (int i = 0; i < candies.Length; i++)
            {
                result[i] =(candies[i] + extraCandies)>= maxCandies;
            }
            return result;
        }
        static void Main(string[] args)
        {
            Program program = new Program();

            int[] candies = { 2, 3, 5, 1, 3 };
            int extraCandies = 3;
            IList<bool> result = program.KidsWithCandies(candies, extraCandies);
            Console.WriteLine("Test case 1: ");
            Console.WriteLine(string.Join(", ", result));

        }
    }
}
