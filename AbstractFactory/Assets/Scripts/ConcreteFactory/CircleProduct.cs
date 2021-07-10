using UnityEngine;

namespace ConcreteFactory
{
    public class CircleProduct : MonoBehaviour,IShapeProduct
    {
        public int Corners => int.MinValue;
    }
}