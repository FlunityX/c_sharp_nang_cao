namespace _name
{
    enum color
    {
        red,
        blue,
        green,
        yellow
    }
    internal class Program
    {
        static void Main(string[] args)
            // nameof biến đổi tên biến thành chuỗi 
        {
           color a = color.red;
           string enumstring = nameof(color)+ "." + nameof(color.blue);
           Console.WriteLine(enumstring);
           Console.ReadLine();
        }
    }
}
