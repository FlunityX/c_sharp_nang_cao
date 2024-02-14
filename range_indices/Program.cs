using System;
using System.Collections.Generic;

namespace range_indices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> a = new List<int>();
            a.AddRange(new int[] { 1, 2, 3, 4, 5, 6, 7 });
            var subArray1 = a[1..5]; // .. là lấy số trong phạm vị
            var subArray2 = a[^1]; // Sử dụng chỉ số âm tính từ cuối 
            Console.WriteLine(string.Join(", ", subArray1)); // In ra dãy phần tử subArray1
            Console.WriteLine(subArray2); // In ra phần tử subArray2
            Console.ReadLine();
        }
    }
}