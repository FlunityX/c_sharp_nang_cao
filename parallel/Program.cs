namespace parallel
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5 };

            Parallel.ForEach(numbers, (number) =>
            {
                Console.WriteLine(number);
            });

            Console.ReadLine();
        }
    }
}
