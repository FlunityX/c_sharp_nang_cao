namespace Count_NUM
{
    internal class Program
    {
        /*Cho xâu S chỉ gồm các chữ số từ 1 tới 9 và dấu cách (space).

        Yêu cầu tính số lượng số nằm trong xâu S, biết các số được ngăn cách nhau bởi một hay nhiều dấu cách.*/
        static void Main()
        {
            string S = "73 9 7 6";
            int count = CountNumbers(S);
            Console.WriteLine("Số lượng số trong chuỗi: " + count);
        }

        static int CountNumbers(string S)
        {
            int count = 0;

            // Dùng biến bool để kiểm tra xem ký tự trước đó có phải là chữ số hay không
            bool previousIsDigit = false;

            foreach (char c in S)
            {
                // Kiểm tra xem ký tự hiện tại có phải là một chữ số không
                if (char.IsDigit(c))
                {
                    // Nếu ký tự trước đó không phải là một chữ số
                    // thì tăng biến đếm lên
                    if (!previousIsDigit)
                    {
                        count++;
                    }
                    previousIsDigit = true;
                }
                else
                {
                    // Nếu không phải là chữ số, đặt biến previousIsDigit thành false
                    previousIsDigit = false;
                }
            }

            return count;
        }
    }
}

