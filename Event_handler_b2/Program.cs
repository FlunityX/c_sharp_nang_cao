namespace Event_handler_b2
{
    public delegate void myeventhandler (object sender , EventArgs s);
    public class myevent
    {
        public event myeventhandler handler;
        public void MyEventHandlerMethod(object sender , EventArgs s)
        {
            Console.WriteLine("event active");
        } 
        public void triggerEvent()
        {
            handler?.Invoke(this,EventArgs.Empty);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
          myevent myevent = new myevent();
            myevent.handler += myevent.MyEventHandlerMethod;
            myevent.triggerEvent();
        }

       
    }
}
