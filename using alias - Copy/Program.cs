namespace using_alias
{
    using print = System.Console;
    using random = System.Random;

    internal class Program
    {
        static void Main(string[] args)
        {
            print.WriteLine("Hello, World!");

            random a = new random();
            int randomNumber = a.Next(0, 10);
            print.WriteLine(randomNumber);

            print.ReadLine();
        }
    }
}



