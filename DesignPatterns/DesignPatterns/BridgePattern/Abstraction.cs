using Windows.UI.Xaml.Media;

namespace DesignPatterns.BridgePattern
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
