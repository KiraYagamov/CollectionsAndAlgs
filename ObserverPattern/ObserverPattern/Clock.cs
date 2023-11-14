using System;

namespace ObserverPattern
{
    public class Clock : IObserver
    {
        public void Update(string time, float temp)
        {
            Console.WriteLine("Текущее время: " + time);
        }
    }
}