using Windows.UI.Xaml.Media;

// Inspired by Judith Bishop's 2007 book C# 3.0 Design Patterns
namespace DesignPatterns.Patterns.BridgePattern
{
    public class Abstraction
    {
        Bridge bridge;

        public Abstraction(Bridge implementation)
        {
            bridge = implementation;
        }

        public string GetVersionName()
        {
            return bridge.GetVersionNameImp();
        }

        public SolidColorBrush GetVersionColor()
        {
            return bridge.GetVersionColorImp();
        }
    }
}
