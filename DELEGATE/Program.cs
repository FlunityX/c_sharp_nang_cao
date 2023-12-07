
namespace delegate1{

    internal class Program
    {
        public delegate void ShowLog(string message);
        static void info (string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
        }
        static void Main(string[] args)
        {
            ShowLog log;
            log = info;
            log("xin chao ");

        }
    } 
}
