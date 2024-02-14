namespace Thực_hành_hướng_sự_kiện
{
    class test
    {
       public EventHandler sendmessage;
        public void guithongbao()
        {
            if(sendmessage != null)
            {
                sendmessage?.Invoke(this, EventArgs.Empty);
            }
            else
            {
                Console.WriteLine(" chưa có người nhận");
            }
        }
    }
    class nhantinhieuthunhat
    {
        public void send(test a)
        {
            a.sendmessage += nguoinhantinhieuthunhat;
        }
        public void nguoinhantinhieuthunhat(object sender, EventArgs e)
        {
            Console.WriteLine("người thứ nhất đã nhận tín hiệu");
        }
    }
    class nhantinhieuthuhai
    {
        public void send(test a)
        {
            a.sendmessage += nguoinhantinhieuthuhai;
        }
        public void nguoinhantinhieuthuhai(object sender, EventArgs e)
        {
            Console.WriteLine("người thứ hai đã nhận tín hiệu");
        } 
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            test guisk = new test();
            nhantinhieuthunhat nv1 = new nhantinhieuthunhat();
            nv1.send(guisk);
            nhantinhieuthuhai nv2 = new nhantinhieuthuhai();
            nv2.send(guisk);
            guisk.guithongbao();
            Console.ReadLine();
        }
    }
}
