namespace ConsoleApp3.Factory
{
    public abstract class AbstractFactory
    {
        public abstract IAbstractProduct Create();
    }

    public abstract class AbstractFactory<TProduct> where TProduct : IAbstractProduct
    {
        public abstract TProduct Create();
    }
}