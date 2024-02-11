
class Program
{
    static void Main()
    {
        int[] numbers = { 1, 2, 3, 4, 5 };

        var evenNumbers = from num in numbers
                          where num % 2 == 0
                          select num;

        foreach (var number in evenNumbers)
        {
            Console.WriteLine(number);
        }
    }
}