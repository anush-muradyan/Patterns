using Factory;

namespace ConcreteFactory
{
    public interface IShapeProduct : IAbstractProduct
    {
        int Corners { get; }
    }
    
}