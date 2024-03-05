using System.Threading.Channels;

namespace patical
{
    /*Trong ngôn ngữ lập trình C#, từ khóa "partial" được sử dụng để khai báo một lớp, một cấu trúc,
     * một phương thức hoặc một kiểu giao diện là một phần của một khai báo toàn diện được chia thành nhiều phần.
     Khi bạn khai báo một lớp hoặc một cấu trúc là một phần, bạn có thể chia phần cài đặt của nó thành nhiều tệp mã khác nhau. */
    public partial class Myclass
    {
        public void print()
        {
            Console.WriteLine("patical 1");
        }
    }
    public partial class Myclass
    {
        public void print1()
        {
            Console.WriteLine("patical 2");
        }
    }
    // Khi biên dịch, hai tệp mã này sẽ được tổng hợp lại thành một lớp duy nhất.
    internal class Program
    {
        static void Main(string[] args)
        {
            Myclass a = new Myclass();
            a.print1();
            a.print();
            Console.ReadLine();
        }
    }
}
