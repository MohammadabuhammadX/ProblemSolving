namespace CanPlaceFlowers605
{
    internal class Program
    {
        public bool CanPlaceFlowers(int[] flowerbed, int n)
        {
            int len = flowerbed.Length;

            for (int i = 0; i < len; i++)
            {
                bool left = i == 0 || flowerbed[i] == 0; 
                bool right = i == len - 1 || flowerbed[i+1] == 0;

                if(left && right&& flowerbed[i] == 0)
                {
                    flowerbed[i] = 1;
                    n--;
                }
            }
            return n <= 0;
        }
        static void Main(string[] args)
        {
            Program program = new Program();

            int[] flowerbed1 = { 1, 0, 0, 0, 1 };
            int n1 = 1;
            bool result1 = program.CanPlaceFlowers(flowerbed1, n1);
            Console.WriteLine($"Test case 1: {result1}");
        }
    }
}
