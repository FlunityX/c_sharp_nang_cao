namespace actiondelegate
{
    internal class Program
    {
        public static void enror(string s)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(s);
            Console.ResetColor();
        }
        public static void warming(string s)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(s);
            Console.ResetColor();
        }
        public static void noissue(string s)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(s);
            Console.ResetColor();
        }
        public static int tong(int a, int b) => a + b;
        public static int hieu(int a, int b) => a - b;
        static void Main(string[] args)
        {
            //Tóm lại, Func được sử dụng cho các phương thức có trả về giá trị,
            //trong khi Action được sử dụng cho các phương thức không trả về giá trị (void).
            Action<string> as1;
            as1 = enror;
            as1 += warming;
            as1 += noissue;
            as1?.Invoke("delegate");
            Func<int,int,int> as2;
            as2 = tong;
            int tinhtong = as2.Invoke(5, 7);
            as2 = hieu;
            int tinhhieu = as2.Invoke(8, 4);
            Console.WriteLine(tinhtong);
            Console.WriteLine(tinhhieu);
            Console.ReadLine();
        }

    }
}