using System;
using System.IO;
using System.Net.Http.Headers;
using System.Runtime.ConstrainedExecution;
using System.Threading.Channels;

namespace MoDauVeIO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // get tên thư mục hiện tại
            DirectoryInfo a = new DirectoryInfo(".");
            Console.WriteLine(a.FullName);
            // get tên thư mục bất kì 
            DirectoryInfo b = new DirectoryInfo(@"C:\123\test1");
            Console.WriteLine(b.FullName);
            Console.WriteLine(b.Name);
            // get thư mục cha 
            Console.WriteLine(b.Parent);
            // get thuộc tính 
            Console.WriteLine(a.Attributes);
            // get thời gian tạo thư mục 
            Console.WriteLine(a.CreationTime);
            
            // tạo thư mục 
            // cách 1 :
            DirectoryInfo c = new DirectoryInfo(@"C:\Users\Administrator\FlunityX");
            c.Create();
            Console.WriteLine("create file FlunityX complete !");
            // cách 2 :
            string d = (@"C:\Users\Administrator\FlunityX1");
            Console.WriteLine("create file FlunityX1 complete !");
            Directory.CreateDirectory(d);
            // kiểm tra sự tại thư mục 
            string path = (@"C:\Users\Administrator\FlunityX1");
            if (Directory.Exists(path))
            {
                Console.WriteLine("thu muc co ton tai  ");
            }
            else Console.WriteLine("thu muc ko ton tai");
            // xoá thư mục 
            Directory.Delete(@"C:\\Users\\Administrator\\FlunityX\");
            Console.WriteLine("da xoa thanh cong thu muc ");
            
            // danh sách file trong path 
            string path1 = (@"C:\Users\Administrator");
            string[] danhsachfile = Directory.GetFiles(path1);
            Console.WriteLine("danh sach cach file trong path do la :");
            foreach(var item in danhsachfile)
            {
                Console.WriteLine(item);
            }
            // tìm kiếm bao nhiêu file dạng x 
            DirectoryInfo path2 =new DirectoryInfo(@"D:\");
            FileInfo[] timmang = path2.GetFiles("*.apk", SearchOption.TopDirectoryOnly);
            Console.WriteLine("tim thay :{0} thu muc dang .apk ",timmang.Length);
            foreach(var g in timmang)
            {
                Console.WriteLine($"{g.FullName}");
            }
            Console.ReadLine();
        }
    }
}