namespace read_only;
class read_only
{
    private readonly int age;
    public read_only(int age) 
    {
        this.age = age;
    }
    public void use_age()
    {
        Console.WriteLine("tuoi "+age);
    }
}
internal class Program
{
    static void Main(string[] args)
    {
        read_only read_ = new read_only(4);
        read_.use_age();
    }
}

