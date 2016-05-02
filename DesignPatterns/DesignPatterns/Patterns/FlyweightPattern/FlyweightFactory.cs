using System.Collections.Generic;

// Inspired by Judith Bishop's 2007 book C# 3.0 Design Patterns
namespace DesignPatterns.Patterns.FlyweightPattern
{
    public class FlyweightFactory
    {
        Dictionary<string, IFlyweight> flyweights = new Dictionary<string, IFlyweight>();

        public FlyweightFactory()
        {
            flyweights.Clear();
        }

        public IFlyweight this[string index]
        {
            get
            {
                if (!flyweights.ContainsKey(index))
                    flyweights[index] = new Flyweight();

                return flyweights[index];
            }
        }
    }
}
