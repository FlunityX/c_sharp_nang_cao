using System.Reflection;

namespace type__get_type_
{
    class hinhdang
    {
        public string name {  get; set; }
        public double chuvi { get; set; }
        public double dientich {  get; set; }
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            hinhdang a = new hinhdang()
            {
                name = "hinh chu nhat",
                chuvi = 14,
                dientich = 12

           };
            foreach(PropertyInfo property in a.GetType().GetProperties()) 
            {
                string property_name = property.Name;
                object value = property.GetValue(a);
                Console.WriteLine(property_name + ": " + value);

            }
            Console.ReadLine();
        }
    }
}
