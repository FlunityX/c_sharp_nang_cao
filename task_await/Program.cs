namespace task_await
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            try
            {
                await MyMethod();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }

            Console.WriteLine("Program completed.");
        }
        public static async Task MyMethod()
        {
            Console.WriteLine("MyMethod started.");

            // Gọi phương thức bất đồng bộ và chờ kết quả
            var result = await MyAsync();

            // Tiếp tục thực hiện các công việc khác sau khi kết quả đã được trả về
            Console.WriteLine($"Result: {result}");
        }
        public static async Task<int> MyAsync()
        {
            Console.WriteLine("MyAsyncMethod started.");

            // Giả lập việc chờ một khoảng thời gian
            await Task.Delay(2000);

            // Trả về một giá trị
            return 42;
        }
    }
}
