using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biểu_thức_lambda_và_hàm_nặc_danh
{
    internal class Program
    {
        // tạo delegate 
        delegate int Calculation(int x, int y);
        // 2 biểu thức lambda
        static Calculation add = (x, y) => x + y;
        static Calculation subtract = (x, y) => x - y;
        static void Main(string[] args)
        {
            int result = add(3, 4);
            int sub = subtract(8, 5);
            Console.WriteLine(result+sub);
            Console.ReadLine();
        }
    }
}
