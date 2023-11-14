using System;
using System.Collections.Generic;

namespace ObserverPattern
{
    public class TemperatureData : ISubject
    {
        private List<IObserver> _observers;
        private float _temp;
        private string _time;

        public TemperatureData()
        {
            _observers = new List<IObserver>();
        }
        public void RegisterObserver(IObserver o)
        {
            _observers.Add(o);
        }

        public void RemoveObserver(IObserver o)
        {
            _observers.Remove(o);
        }

        public void NotifyObservers()
        {
            foreach (IObserver observer in _observers)
            {
                observer.Update(_time, _temp);
            }
        }

        private void DataChanged()
        {
            NotifyObservers();
        }

        public void SetData(string time, float temp)
        {
            this._time = time;
            this._temp = temp;
            DataChanged();
        }
    }
}