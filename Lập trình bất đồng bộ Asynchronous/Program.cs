using System;
using System.Collections.Generic;
using System.Linq;

using System.Threading;
using System.Threading.Tasks;

namespace Lập_trình_bất_đồng_bộ_Asynchronous_
{
    internal class Program
    {
        static void Dosomething(int s, string mps, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            for (int i = 1; i <= s; i++)
            {
                Thread.Sleep(2000); //2000 mps = 2s
                Console.WriteLine($"{i}, {mps}");
            }
            Console.ResetColor();

            lock (lockObject)
            {
                // khoá biến lockObject chạy tác vụ xong mới trả lại lockObject
                Console.WriteLine("---");
                if (s > 1)
                {
                    Dosomething(s - 1, "hello", ConsoleColor.Magenta);
                }
            }
        }
        /* lockObject được sử dụng như một đối tượng khóa. Khi một luồng gặp phần mã lock (lockObject),
         * nó sẽ yêu cầu khóa lockObject và chỉ khi khóa đã được lấy,
         * luồng đó mới có quyền thực hiện các câu lệnh bên trong khối lock.*/
        static object lockObject = new object();

        static void Main(string[] args)
        {
            Task t2 = Task.Run(() => {
                Dosomething(5, "hello", ConsoleColor.Cyan);
            });

            Console.WriteLine("world");
            //Task.WaitAll(t2) được sử dụng để đợi cho tác vụ t2 hoàn thành trước khi chương trình kết thúc.
            Task.WaitAll(t2);
            Console.ReadLine();
        }
    }
}