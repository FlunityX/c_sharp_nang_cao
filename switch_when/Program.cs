using System;

namespace switch_when_example
{
    class Program
    {
        static void Main(string[] args)
        {
            // Cách 1
            object value = "OpenAI";
            string result;

            switch (value)
            {
                case int intValue:
                    result = "Value is an integer";
                    break;
                case double doubleValue:
                    result = "Value is a double";
                    break;
                case string stringValue when stringValue.Length > 5:
                    result = "Value is a string with length greater than 5";
                    break;
                case string stringValue:
                    result = "Value is a string";
                    break;
                default:
                    result = "Value doesn't match any expected type";
                    break;
            }

            Console.WriteLine(result);

            // Cách 2
            object value1 = "OpenAI";
            string result1 = value1 switch
            {
                int intValue => "Value is an integer",
                double doubleValue => "Value is a double",
                string stringValue when stringValue.Length > 5 => "Value is a string with length greater than 5",
                string stringValue => "Value is a string",
                _ => "Value doesn't match any expected type"
            };

            Console.WriteLine(result1);
        }
    }
}