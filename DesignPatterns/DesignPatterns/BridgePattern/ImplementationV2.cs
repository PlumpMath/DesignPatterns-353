using Windows.UI;
using Windows.UI.Xaml.Media;

namespace DesignPatterns.BridgePattern
{
    class ImplementationV2 : Bridge
    {
        public string GetVersionNameImp()
        {
            return "version 2";
        }

        public SolidColorBrush GetVersionColorImp()
        {
            return new SolidColorBrush(Colors.Cyan);
        }
    }
}
