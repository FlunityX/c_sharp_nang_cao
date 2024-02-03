using System.Text;

namespace string_builder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("hello");
            stringBuilder.Insert(5, " world");
                              
            stringBuilder.Replace("world", "universe");
            string stringresult = stringBuilder.ToString();
            Console.Write(stringresult);
            Console.ReadLine();
        }
    }
}
