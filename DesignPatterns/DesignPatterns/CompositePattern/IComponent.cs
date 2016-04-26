using System.Collections.Generic;

namespace DesignPatterns.CompositePattern
{
    public interface IComponent<T>
    {
        void Add(IComponent<T> c);


        T TypeName { get; set; }


        List<IComponent<T>> ItemsList { get; set; }

    }
}
