namespace ienumerable
{
    /*IEnumerable là một interface trong .NET Framework và .NET Core, 
     * nằm trong namespace System.Collections. Interface này đại diện 
     * cho một tập hợp các phần tử có thể được liệt kê một cách tuần tự.
     IEnumerable khai báo một phương thức GetEnumerator() để trả về
    một đối tượng của interface IEnumerator. Interface IEnumerator 
    chứa các phương thức để duyệt qua các phần tử trong tập hợp, bao gồm 
    phương thức MoveNext() để di chuyển đến phần tử tiếp theo và phương 
    thức Current để lấy phần tử hiện tại.
    Khi một đối tượng triển khai interface IEnumerable được liệt kê, 
    nó có thể được sử dụng trong các vòng lặp foreach để duyệt qua
    từng phần tử trong tập hợp một cách dễ dàng.*/
    internal class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<int> ints = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            IEnumerable<int> sochan = ints.Where(n => n % 2 == 0);
            foreach(int s in sochan)
            {
                Console.WriteLine(s);
            }
            Console.ReadLine();
        }
    }
}
