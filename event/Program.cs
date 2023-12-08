namespace event1;

internal class Program
{
    // Một Publisher trong C# là một đối tượng mà chứa định nghĩa của event và delegate đó. Mối liên hệ event-delegate cũng được định nghĩa trong đối tượng này.
    // Một đối tượng lớp Publisher triệu hồi Event và nó được thông báo tới các đối tượng khác.
    //Một Subscriber trong C# là một đối tượng mà chấp nhận event và cung cấp một Event Handler
    //. Delegate trong lớp Publisher triệu hồi phương thức (Event Handler) của lớp Subscriber
    public class EventManager
    {
        public delegate void EventHandler(string message);
        public event EventHandler EventOccurred;

        public void TriggerEvent(string message)
        {
            // Kiểm tra xem sự kiện có người đăng ký hay không trước khi gọi
            EventOccurred?.Invoke(message);
        }
    }

    public class Subscriber
    {
        private string name;

        public Subscriber(string name, EventManager eventManager)
        {
            this.name = name;
            eventManager.EventOccurred += HandleEvent;
        }

        public void HandleEvent(string message)
        {
            Console.WriteLine($"{name} received event: {message}");
        }
    }
        static void Main(string[] args)
        {
            EventManager eventManager = new EventManager();
            Subscriber subscriber1 = new Subscriber("Subscriber 1", eventManager);
            Subscriber subscriber2 = new Subscriber("Subscriber 2", eventManager);

            eventManager.TriggerEvent("Hello, World!");

            Console.ReadLine();
        }

}
