namespace ProblemSolving
{
    internal class Program
    {
        public int Search(int[] nums, int targent)
        {
            int left = 0;
            int right = nums.Length - 1;

            while (left < right)
            {
                int mid = (left + right) / 2;

                int guess = nums[mid];

                if (guess == targent)
                    return mid;

                if (guess < targent)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
            return -1;
        }
        static void Main(string[] args)
        {
            var program = new Program();
            int[] nums = { -1, 0, 3, 5, 9, 12 };
            int targent = 9;
            int result = program.Search(nums, targent);
            Console.WriteLine(result);
        }
    }
}
