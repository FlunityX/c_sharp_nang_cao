

namespace ôn_lập_trình_hướng_sự_kiện
{
    public delegate void TemperatureChangedEventHandler(float newTemperature);

    public class TemperatureSender
    {
        public event TemperatureChangedEventHandler TemperatureChanged;
        private float currentTemperature;

        public float CurrentTemperature
        {
            get { return currentTemperature; }
            set
            {
                if (value != currentTemperature)
                {
                    currentTemperature = value;
                    OnTemperatureChanged(currentTemperature);
                }
                else
                {
                    Console.WriteLine("nhiet do ko bien doi");
                }
            }
        }

        protected virtual void OnTemperatureChanged(float newTemperature)
        {
            TemperatureChanged?.Invoke(newTemperature);
        }
    }

    class TemperatureDisplay
    {
        public void Subscribe(TemperatureSender sender)
        {
            sender.TemperatureChanged += HandleTemperatureChanged;
        }

        public void HandleTemperatureChanged(float newTemperature)
        {
            Console.WriteLine($"Nhiệt độ hiện tại là {newTemperature} độ C");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            TemperatureDisplay temperatureDisplay = new TemperatureDisplay();
            TemperatureSender temperatureSender = new TemperatureSender();
            temperatureDisplay.Subscribe(temperatureSender);
            temperatureSender.CurrentTemperature = 34.5f;
            temperatureSender.CurrentTemperature = 36.7f;
            temperatureSender.CurrentTemperature = 7f;
            Console.ReadLine();
        }
    }
}