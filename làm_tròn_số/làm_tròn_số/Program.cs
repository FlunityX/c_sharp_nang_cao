using System;

class Program
{
    static void Main(string[] args)
    {
        float number = 3.7f;

        int ceilResult = (int)Math.Ceiling(number); // ceilResult = 4
        int floorResult = (int)Math.Floor(number); // floorResult = 3
        int roundedResult = (int)Math.Round(number); // roundedResult = 4

      
        Console.WriteLine("so dc ceil :"+ceilResult);
        Console.WriteLine("so dc floor :"+floorResult);
        Console.WriteLine("so dc round :"+ roundedResult);
        Console.ReadLine();
    }
}