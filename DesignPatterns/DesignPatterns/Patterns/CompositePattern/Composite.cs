using System.Collections.Generic;

// Inspired by Judith Bishop's 2007 book C# 3.0 Design Patterns
namespace DesignPatterns.Patterns.CompositePattern
{
    public class Composite<T> : IComponent<T>
    {
        public List<IComponent<T>> ItemsList { get; set; }

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
