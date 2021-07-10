using System;
using System.Collections.Generic;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new Subject();
            a.Add(new firstObserver(4));
            a.Add(new firstObserver(2));
            a.Notify(4);
        }
    }

    public abstract class Observer
    {
        public abstract void Update(int number);
    }

    public class firstObserver : Observer
    {
        public int observerNumber;

        public firstObserver(int number)
        {
            observerNumber = number;
        }

        public override void Update(int number)
        {
            observerNumber = number;
        }

    }

    class Subject
    {
        private List<Observer> observers = new List<Observer>();

        public void Add(Observer observer)
        {
            observers.Add(observer);
        }

        public void Remove(Observer observer)
        {
            observers.Remove(observer);
        }

        public void Notify(int number)
        {
            foreach (var observer in observers)
            {
                observer.Update(number);
             
            }
        }
    }
}