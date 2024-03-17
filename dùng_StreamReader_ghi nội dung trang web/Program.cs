using System.Globalization;
using System.Net;
using System.Text;


namespace dùng_StreamReader_ghi_nội_dung_trang_web
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            await DelayAndPrint("bắt đầu chương trình ");
            await GetDaTaWeb();
            await DelayAndPrint("đã hoàn thành ");
            
            Console.ReadLine();
        }
        static async Task GetDaTaWeb()
        {
            string WebUrl = "https://github.com/FlunityX";
            await DelayAndPrint("tải nội dung từ URL");

            // Tạo một đối tượng WebRequest để tải nội dung từ URL.
            WebRequest request = WebRequest.Create(WebUrl);
            await DelayAndPrint("Gửi yêu cầu và nhận phản hồi từ máy chủ");

            // Gửi yêu cầu và nhận phản hồi từ máy chủ.
            WebResponse response = request.GetResponse();
            await DelayAndPrint("Lấy luồng dữ liệu từ phản hồi.");

            // Lấy luồng dữ liệu từ phản hồi.
            Stream responseStream = response.GetResponseStream();
            await DelayAndPrint("nó cps thay thế đc console.writeline trong đoạn code này ko"); 
            // Sử dụng StreamReader để đọc nội dung từ luồng dữ liệu.
            StreamReader reader = new StreamReader(responseStream);
            await DelayAndPrint(" Sử dụng StreamReader để đọc nội dung từ luồng dữ liệu.");
            // Đọc và in ra nội dung trang web.
            string content = reader.ReadToEnd();
            await DelayAndPrint(" Đọc và in ra nội dung trang web.");
            Console.WriteLine(content);
            if(content != null)
            {
               await using (StreamWriter writer = new StreamWriter(@"C:\Users\Administrator\source\repos\baitap.txt"))
                {
                    writer.Write(content);
                }

            }
            else
            {
               await using (StreamWriter writer = new StreamWriter(@"C:\Users\Administrator\source\repos\baitap.txt"))
                {
                    writer.Write("ko co gi");
                }
            }

        }
        static async Task DelayAndPrint(string message)
        {
            await Task.Delay(1000);
            Console.WriteLine(message);
        }
    }
}
