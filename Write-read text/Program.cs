using static System.Net.Mime.MediaTypeNames;

namespace Write_text
{
    internal class Program
    {
        // lập trình bất đồng bộ 
        // phương thức bất đồng bộ thêm async Task và await 
        public static async Task Main(string[] args)
        {
            // đường đãn đến file 
            string filepath = @"C:\\Users\\Administrator\\source\\repos\\testasync.txt";
            try
            {
                // 1.dừng chương trình chính và chạy phương thức SimpleWriteAsync
                await SimpleWriteAsync(filepath);
                // 4. chạy lệnh này 
                Console.WriteLine("đã hoàn thành ");
                // 5. delay 1 s
                await Task.Delay(1000);
                // 6. chạy phương thức bất đông bộ SimpleReadAsync
                string a = await SimpleReadAsync(filepath);
                // 10. in ra chuỗi trong SimpleReadAsync
                Console.WriteLine(a);

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("---");
            Console.ReadLine();

        }
        public static async Task SimpleWriteAsync(string filepath)
        {
            Console.WriteLine("delay write 2 second");
            string text = "nội dung này là lưu tập tin";
            // 2.chờ 2 s
            await Task.Delay(2000);
            // 3. ghi nội dung tệp
            await File.WriteAllTextAsync(filepath, text);
        }
        public static async Task<string> SimpleReadAsync(string filepath )
        {
            //7.chạy ra console bên dưới 
            Console.WriteLine("delay read 2 second"); 
            // 8. delay 2s 
            await Task.Delay(2000);
            // 9. trả về và đợi File đọc kiểu bất đồng bộ
            return await File.ReadAllTextAsync(filepath);
        }
    }
}
