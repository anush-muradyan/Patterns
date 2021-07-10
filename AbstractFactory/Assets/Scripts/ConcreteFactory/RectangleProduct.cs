using UnityEngine;

namespace ConcreteFactory
{
    public class RectangleProduct : MonoBehaviour,IShapeProduct
    {
        public int Corners => 4;
    }
}