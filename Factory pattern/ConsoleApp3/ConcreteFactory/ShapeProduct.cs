using ConsoleApp3.Factory;

namespace ConsoleApp3.ConcreteFactory
{
    public abstract class ShapeProduct : IAbstractProduct
    {
        public int Corners { get; private set; }


        protected ShapeProduct(int corners)
        {
            Corners = corners;
        }
    }
}