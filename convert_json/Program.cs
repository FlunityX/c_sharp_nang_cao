using System.Text.Json;
using System.IO;
namespace convert_json
{
    internal class Program
    {
        static void Main(string[] args)
        {
         

            var person = new { Name = "John", Age = 30, City = "New York" };

            string json = JsonSerializer.Serialize(person);

            if (!string.IsNullOrEmpty(json))
            {
                Console.WriteLine("Chuyển đổi thành công thành JSON:");
                Console.WriteLine(json);
            }
            else
            {
                Console.WriteLine("Chuyển đổi không thành công.");
            }
            string filePath = @"D:\test.txt";
            File.WriteAllText(filePath, json);
        }
    }
}
