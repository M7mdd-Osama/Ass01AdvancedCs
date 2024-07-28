namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] Numbers = { 3, 0, 5, 4, 2, 4, 6, 8, 7, 6, 1 };

            Helper.BubbleSort(Numbers);

            foreach (int i in Numbers)
            {
                Console.Write($"{i} " );
            }
        }
    }
}
