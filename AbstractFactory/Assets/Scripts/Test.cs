using ConcreteFactory;
using UnityEngine;

namespace DefaultNamespace
{
    public class Test : MonoBehaviour
    {
        [SerializeField] private ShapeFactory shapeFactory;
        [SerializeField] private ColorFactory colorFactory;

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                shapeFactory.Create<CircleProduct>();
            }

            if (Input.GetKeyDown(KeyCode.KeypadEnter))
            {
                shapeFactory.Create<RectangleProduct>();
            }
            
            if (Input.GetKeyDown(KeyCode.R))
            {
                colorFactory.Create<RedProduct>();
            }
            
            if (Input.GetKeyDown(KeyCode.G))
            {
                colorFactory.Create<GreenProduct>();
            }
        }
    }
}
