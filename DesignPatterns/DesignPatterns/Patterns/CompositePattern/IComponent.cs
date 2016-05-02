using System.Collections.Generic;

// Inspired by Judith Bishop's 2007 book C# 3.0 Design Patterns
namespace DesignPatterns.Patterns.CompositePattern
{
    public interface IComponent<T>
    {
        void Add(IComponent<T> c);


        T TypeName { get; set; }


        List<IComponent<T>> ItemsList { get; set; }

    }
}
