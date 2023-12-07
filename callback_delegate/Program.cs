using System;

namespace callback_delegate
{
    class Program
    {
        public delegate double CanhA(int a);

        public static double ChuVi(int a)
        {
            return a * 4;
        }

        public static double DienTich(int a)
        {
            return a * a;
        }

        public static double TichCanhVoiChuVi(int a, CanhA callback)
        {
            double chuVi = callback.Invoke(a);
            return a *chuVi;
        }
        public static double TichCanhVoidientich(int a, CanhA callback)
        {
            double dientich = callback.Invoke(a);
            return a * dientich;
        }

        static void Main(string[] args)
        {
            CanhA callback = ChuVi;

            double result = TichCanhVoiChuVi(5, ChuVi);
           // Trong phương thức TichCanhVoiChuVi, bạn đã khai báo một tham số là a kiểu int và một tham số là callback kiểu CanhA(một delegate).
           // Trong phương thức này, bạn sử dụng callback.Invoke(a) để gọi phương thức callback và truyền tham số a vào.

            //  Nếu chúng ta gọi TichCanhVoidientich(5, DienTich),
            //  phương thức callback DienTich sẽ được gọi với tham số 5.Phương thức DienTich trả về diện tích của hình vuông với cạnh là 5,
            //  tức là 25.
            double result1 = TichCanhVoidientich(5, DienTich);
            // tuỳ vào truyền vào phương thức gì delegate sẽ call back đến phương thức đó
            Console.WriteLine("Kết quả: " + result);
            Console.WriteLine("Kết quả: " + result1);
            Console.ReadLine();
        }
    }
}