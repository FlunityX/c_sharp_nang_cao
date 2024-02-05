using System.Text.RegularExpressions;

namespace Regular_Expression
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "Hello123";

            // Kiểm tra xem chuỗi có chứa chữ số hay không
            bool isMatch = Regex.IsMatch(input, @"\d");

            Console.WriteLine(isMatch);
            string input1 = "Hello123 World456";

            // Tìm tất cả các chuỗi chứa chữ số
            MatchCollection matches = Regex.Matches(input1, @"\d");

            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value); // Output: 1, 2, 3, 4, 5, 6
            }
            Console.ReadLine();
        }

       
        }
  
    }

