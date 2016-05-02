using System;
using System.Collections.Generic;
using Windows.UI.Xaml.Shapes;

// Inspired by Judith Bishop's 2007 book C# 3.0 Design Patterns
namespace DesignPatterns.Patterns.CompositePattern
{
    public class Component<T> : IComponent<T>
    {
        public T TypeName { get; set; }

        public List<IComponent<T>> ItemsList
        {
            get
            {
                throw new Exception("Can't create a List in an Item");
            }

            set
            {
                throw new Exception("Can't create a List in an Item");
            }
        }

        public Rectangle RectangleItem { get; set; }


        public Component(T type)
        {
            TypeName = type;

            // T newT1 = (T)(object)type;
            //Rectangle newT2 = (Rectangle)(object)type;

            if (type.GetType() == typeof(Rectangle))
                RectangleItem = (Rectangle)(object)type;

        }

        public void Add(IComponent<T> c)
        {
            throw new Exception("Can't add to an item");
        }
    }
}
