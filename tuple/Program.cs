namespace tuple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // một Tuple là một kiểu dữ liệu được sử dụng để lưu trữ một tập hợp các giá trị có thể khác nhau.
            // Một Tuple có thể chứa một hoặc nhiều phần tử, và mỗi phần tử có thể có kiểu dữ liệu khác nhau.
            Tuple<string, int, bool> tp = new Tuple<string, int, bool>("hello ", 1, true);
            // cách khác 
            // var mytuple = Tuple.Create("hello ", 1, true);
            string mystring = tp.Item1;
            int myint = tp.Item2;
            bool mybool = tp.Item3; 
            Console.WriteLine(mystring);
            Console.WriteLine(myint);   
            Console.WriteLine(mybool);
            Console.ReadLine();
            
        }
    }
}
