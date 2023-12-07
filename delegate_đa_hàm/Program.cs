namespace delegate_đa_hàm
{
    internal class Program
    {
        // xuất thông báo "enror" màu đỏ , "warming" màu vàng và "no issue found" màu xanh cùng 1 delegate
        // xuất cả 3 cùng 1 thông điệp " chương trình đã thực thi"
        // delegate thongbao trỏ đến từng hàm 
        public delegate void thongbao(string s);
        public static void enror(string s)
        {
          Console.ForegroundColor = ConsoleColor.Red;
          Console.WriteLine(s);
          Console.ResetColor();
        }
        public static void warming (string s)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(s);
            Console.ResetColor();
        }
        public static void noissue(string s)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine (s);
            Console.ResetColor();

        }
        static void Main(string[] args)
        {
            thongbao tb = null;
            tb = enror;
            tb("erorr");
            tb = warming;
            tb("warming");
            tb = noissue;
            tb("no issue found ");
            tb = enror;
            tb += warming;
            tb += noissue;
            tb("chuong trinh da dc thuc thi ");
            Console.ReadLine();
        }
    }
}