using System;

namespace Switch_8_0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* expression switch
            {
                pattern1 => Mã khi pattern1 khớp với expression,
                pattern2 =>  Mã khi pattern2 khớp với expression,
                            Các mẫu khác...
                _ =>  Mã mặc định khi không có mẫu nào khớp với expression
            };*/
            char grade = 'A';
            string result = grade switch
            {
                'A' => "excellent",
                'B' => "good",
                _=> "needs improvement"
            };

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}