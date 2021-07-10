using UnityEngine;

namespace Factory
{
    public abstract class AbstractFactory : MonoBehaviour
    {
    }

    public abstract class AbstractFactory<TProduct> : AbstractFactory where TProduct : IAbstractProduct
    {
        public abstract TConcrete Create<TConcrete>() where TConcrete : TProduct;
    }

    public abstract class AbstractFactoryFromResource<TProduct> : AbstractFactory where TProduct : IAbstractProduct
    {
        public abstract TConcrete Create<TConcrete>() where TConcrete : Object, TProduct;
    }

    public class FactoryFromResource<TProduct> : AbstractFactoryFromResource<TProduct> where TProduct : IAbstractProduct
    {
        [SerializeField] private string folderName;

        public sealed override TConcrete Create<TConcrete>()
        {
            var prefabName = typeof(TConcrete).Name;
            var path = $"{folderName}/{prefabName}";
            var productPrefab = Resources.Load<TConcrete>(path);
            var product = Instantiate(productPrefab);
            return product;
        }
    }
}