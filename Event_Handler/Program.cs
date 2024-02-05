using System;

namespace Event_Handler
{
    public class myevent : EventArgs
    {
        public myevent(string data) 
        {
            this.data =data;
        }
        // lưu dữ liệu từ publisher
        private string data;
        // property
        public string Getdata(string data)
        {
            return data;
        }

    } 
    public class A
    {
        public event EventHandler<myevent> handler;
        public void send()
        {
           handler?.Invoke(this , new myevent("đã nhận sự kiện"));
        }
    }
    class B 
    {
        public void sub(A p)
        {
            p.handler += nhansk;
        }
        public void nhansk(object sender ,myevent e)
        {
            Console.WriteLine("class B"+ e.Getdata("b"));
        }

    }
    class c
    {
        public void sub(A p)
        {
            p.handler += nhansk;
        }
        public void nhansk(object sender, myevent e)
        {
            Console.WriteLine("class c" + e.Getdata("c"));
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            B b = new B();
            c c = new c();
            c.sub(a);
            b.sub(a);
            a.send();
            Console.ReadLine();
        }
    }
}
