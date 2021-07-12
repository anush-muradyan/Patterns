using System;

namespace Adapter
{
    public class AdapterV2<T> : IType<T> where T : IType<T>
    {
        private T _type;

        public AdapterV2(T type)
        {
            _type = type;
        }

        public T Work()
        {
            Console.WriteLine("AD Work");

            return _type.Work();
        }
    }

    public interface IType<T>
    {
        T Work();
    }

    public class AD : IType<AD>
    {
        public AD Work()
        {
            Console.WriteLine("AD");
            return this;
        }
    }

    public class Adapter : ITarget
    {
        private Adaptee _adaptee;

        public Adapter(Adaptee adaptee)
        {
            _adaptee = adaptee;
        }

        public void OnRequest()
        {
            _adaptee.Request();
        }
    }

    public class Adaptee
    {
        public void Request()
        {
            Console.WriteLine("I am called from Adaptee!\n");
        }
    }

    interface ITarget
    {
        void OnRequest();
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Adaptee Adaptee = new Adaptee();
            // ITarget t = new Adapter(Adaptee);
            // t.OnRequest();

            AD ad = new AD();
            var ad2 = new AdapterV2<AD>(ad);
            AD result = ad2.Work();
        }
    }
}