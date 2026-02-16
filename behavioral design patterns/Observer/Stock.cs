using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD.behavioral_design_patterns.Observer
{
    public class Stock : ISubject
    {
        private readonly List<IObserver> _observers = new();
        private decimal _price;

        public decimal Price
        {
            get => _price;
            set
            {
                _price = value;
                Notify();
            }
        }

        public void Attach(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.Update(_price);
            }
        }
    }

}
