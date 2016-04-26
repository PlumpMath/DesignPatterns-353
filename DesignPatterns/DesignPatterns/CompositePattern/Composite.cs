using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CompositePattern
{
    public class Composite<T> : IComponent<T>
    {
        public List<IComponent<T>> ItemsList { get; set; }

        IComponent<T> holder = null;

        public T TypeName { get; set; }

        public Composite()
        {
            ItemsList = new List<IComponent<T>>();
        }

        public void Add(IComponent<T> c)
        {
            ItemsList.Add(c);
        }
    }
}
