using Windows.UI;
using Windows.UI.Xaml.Media;

namespace DesignPatterns.BridgePattern
{
    class ImplementationV1 : Bridge
    {
        public string GetVersionNameImp()
        {
            return "version 1";
        }

        public SolidColorBrush GetVersionColorImp()
        {
            return new SolidColorBrush(Colors.Magenta);
        }
    }
}
