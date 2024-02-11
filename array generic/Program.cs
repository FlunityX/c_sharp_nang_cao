using System;

public class GenericArrayExample<T>
{
    private T[] myArray;

    public GenericArrayExample(int length)
    {
        // Khởi tạo mảng với tham số kiểu T
        myArray = new T[length];
    }

    public void SetValue(int index, T value)
    {
        // Gán giá trị cho phần tử trong mảng
        myArray[index] = value;
    }

    public T GetValue(int index)
    {
        // Trả về giá trị của phần tử trong mảng
        return myArray[index];
    }

    public void PrintArray()
    {
        // In ra các phần tử trong mảng
        for (int i = 0; i < myArray.Length; i++)
        {
            Console.WriteLine("Element " + i + ": " + myArray[i]);
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // Tạo một đối tượng GenericArrayExample với tham số kiểu int
        GenericArrayExample<int> intArray = new GenericArrayExample<int>(5);

        // Gán giá trị cho các phần tử trong mảng
        intArray.SetValue(0, 1);
        intArray.SetValue(1, 2);
        intArray.SetValue(2, 3);
        intArray.SetValue(3, 4);
        intArray.SetValue(4, 5);

        // In ra các phần tử trong mảng
        intArray.PrintArray();

        // Tạo một đối tượng GenericArrayExample với tham số kiểu string
        GenericArrayExample<string> stringArray = new GenericArrayExample<string>(3);

        // Gán giá trị cho các phần tử trong mảng
        stringArray.SetValue(0, "Hello");
        stringArray.SetValue(1, "World");
        stringArray.SetValue(2, "!");

        // In ra các phần tử trong mảng
        stringArray.PrintArray();
    }
}