using System;

namespace Strategy
{
    interface IStrategy<T>
    {
        T GetResult();
    }

    public abstract class NumberStrategy : IStrategy<int>
    {
        protected int A { get; }
        protected int B { get; }

        protected NumberStrategy(int a, int b)
        {
            A = a;
            B = b;
        }

        public abstract int GetResult();
    }

    public class AddNumberStrategy : NumberStrategy
    {
        public AddNumberStrategy(int a, int b) : base(a, b)
        {
        }

        public override int GetResult()
        {
            return A + B;
        }
    }

    public class SubtractNumberStrategy : NumberStrategy
    {
        public SubtractNumberStrategy(int a, int b) : base(a, b)
        {
        }

        public override int GetResult()
        {
            return A - B;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {

            int a = 5;
            int b = 2;

            PrintResult(new AddNumberStrategy(a,b));
            PrintResult(new SubtractNumberStrategy(a,b));
            // FirstStrategyAnush s = new FirstStrategyAnush();
            // var a = new SomeClass(s);
            // a.StrategyAnush.DoSomething();
        }

        public static void PrintResult(IStrategy<int> strategy)
        {
            var result = strategy.GetResult();
            Console.WriteLine(result);
        }
    }

//ANUSH CODE
    class SomeClass
    {
        public IStrategyAnush StrategyAnush;

        public SomeClass(IStrategyAnush strategyAnush)
        {
            StrategyAnush = strategyAnush;
        }
    }

    interface IStrategyAnush
    {
        void DoSomething();
    }

    class FirstStrategyAnush : IStrategyAnush
    {
        public void DoSomething()
        {
            Console.WriteLine("first strategy function called!");
        }
    }
}