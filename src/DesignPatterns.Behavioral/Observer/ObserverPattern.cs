using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Observer
{
    public interface IObserver
    {
        void Update(float temperature);
    }

    public class DisplayDecive : IObserver
    {
        private string _name;
        public DisplayDecive(string name)
        {
            _name = name;
        }
        public void Update(float temperature)
        {
            Console.WriteLine($"{_name} received temperature update: {temperature}°C");
        }
    }

    public class MobileDevice : IObserver
    {
        private string _name;
        public MobileDevice(string name)
        {
            _name = name;
        }
        public void Update(float temperature)
        {
            Console.WriteLine($"{_name} received temperature update: {temperature}°C");
        }
    }

    public interface ISubject
    {
        void RegisterObserver(IObserver observer);
        void RemoveObserver(IObserver observer);
        void NotifyObservers();
    }

    public class WeatherStation : ISubject
    {
        private List<IObserver> _observers;
        private float _temperature;
        public WeatherStation()
        {
            _observers = new List<IObserver>();
        }
        public void RegisterObserver(IObserver observer)
        {
            _observers.Add(observer);
        }
        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }
        public void NotifyObservers()
        {
            foreach (var observer in _observers)
            {
                observer.Update(_temperature);
            }
        }
        public void SetTemperature(float temperature)
        {
            _temperature = temperature;
            NotifyObservers();
        }
    }

    public class ObserverPattern
    {
        //public static void Main(string[] args)
        //{
        //    WeatherStation weatherStation = new WeatherStation();
        //    DisplayDecive display1 = new DisplayDecive("Display 1");
        //    MobileDevice mobile1 = new MobileDevice("Mobile 1");
        //    weatherStation.RegisterObserver(display1);
        //    weatherStation.RegisterObserver(mobile1);
        //    weatherStation.SetTemperature(25.5f);
        //    weatherStation.RemoveObserver(display1);
        //    weatherStation.SetTemperature(30.0f);
        //}
    }
}
