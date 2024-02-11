using System;

class Program
{
    static void Main()
    {
        string inputString = "  Hello, World!  ";

        // Loại bỏ khoảng trắng không cần thiết từ đầu và cuối chuỗi
        string trimmedString = inputString.Trim();
        Console.WriteLine("Trimmed string: " + trimmedString);

        // Tách chuỗi thành mảng các từ sử dụng dấu phẩy và khoảng trắng làm phân tách
        string[] words = trimmedString.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
        Console.WriteLine("Words:");
        foreach (string word in words)
        {
            Console.WriteLine(word);
        }

        // Kết hợp các phần tử của mảng thành một chuỗi, sử dụng dấu phẩy và khoảng trắng làm phân tách
        string joinedString = string.Join(", ", words);
        Console.WriteLine("Joined string: " + joinedString);
    }
}
