using System;

namespace ObserverPattern
{
    public class Termometr : IObserver
    {
        public void Update(string time, float temp)
        {
            Console.WriteLine("Текущая температура: " + temp);
        }
    }
}