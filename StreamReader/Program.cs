using System;
using System.IO;

namespace StreamReaderExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"D:\design_pattern\singleton\nhanvatgame\Program.cs";

            try
            {
                // Open the JavaScript file to read
                using (StreamReader sr = new StreamReader(filePath))
                {
                    // Read the content of the file
                    string content = sr.ReadToEnd();

                    // Display the content of the file
                    Console.WriteLine(content);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
            Console.ReadLine();
        }
    }
}