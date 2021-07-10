namespace ConsoleApp3
{
    public enum Products
    {
       Chair,
       Sofa,
       Table
    }
    
    public abstract class AbstractProduct:IFactory
    {
        public abstract Products creatProduct(Products product);

    }


    public class ChairProduct : AbstractProduct
    {
        public override Products creatProduct(Products product)
        {
            return Products.Chair;
        }
    }
    
    public class SofaProduct : AbstractProduct
    {
        public override Products creatProduct(Products product)
        {
            return Products.Sofa;
        }
    }
    
    public class TableProduct : AbstractProduct
    {
        public override Products creatProduct(Products product)
        {
            return Products.Table;
        }
    }
}