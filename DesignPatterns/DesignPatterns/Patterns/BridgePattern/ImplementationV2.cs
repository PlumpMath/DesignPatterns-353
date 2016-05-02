using Windows.UI;
using Windows.UI.Xaml.Media;

// Inspired by Judith Bishop's 2007 book C# 3.0 Design Patterns
namespace DesignPatterns.Patterns.BridgePattern
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
