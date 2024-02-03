using System.Text;

namespace filestream
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "data.cs";
            using var stream = new FileStream(path:path,FileMode.Create);
            // lưu data 
            byte[] buffer = { 1, 2, 3 };
            stream.Write(buffer, 0, buffer.Length);
            // đọc dữ liệu 
            int sobytedocdc =stream.Read(buffer, 0, buffer.Length);
            // int,docble --> byte 
            int abc = 1;
            var byte_abc = BitConverter.GetBytes(abc);
            string s = "abc";
            var byte_s = Encoding.UTF8.GetBytes(s);
            // byte --> int , double ...
            BitConverter.ToInt32(byte_abc, 0);
            Encoding.UTF8.GetString(byte_s, 0, byte_s.Length);

        }
    }
}
