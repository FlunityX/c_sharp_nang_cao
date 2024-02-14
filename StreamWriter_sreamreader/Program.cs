using System.IO;
namespace StreamWriter_sreamreader
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a new instance of StreamWriter to write to a file
            // using giải phóng tài nguyên sau khi sử dụng 
            using (StreamWriter writer = new StreamWriter(@"C:\\Users\\Administrator\\source\\repos\\test.txt"))
            {
                // Write text to the file
                writer.WriteLine("Hello, World!");
                writer.WriteLine("This is a sample text.");
            }
            Console.WriteLine("Text has been written to the file.");
            string filePath = @"C:\Users\Administrator\source\repos\test.txt";

            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    // fileContent đọc hết file 
                    string fileContent = reader.ReadToEnd();
                    Console.WriteLine("File content:");
                    Console.WriteLine(fileContent);
                }
            }
            catch (FileNotFoundException)
            // ngoại lệ file ko hợp lệ 
            {
                Console.WriteLine($"File '{filePath}' not found.");
            }
            catch (IOException e) 
            // ngoại lệ IO file ko hợp lệ
            {
                Console.WriteLine($"An error occurred while reading the file: {e.Message}");
            }

            Console.ReadLine();
        }
    }
}
