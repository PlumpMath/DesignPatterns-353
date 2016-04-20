using Windows.UI.Xaml.Media;

namespace DesignPatterns.BridgePattern
{
    public interface Bridge
    {
        string GetVersionNameImp();

        SolidColorBrush GetVersionColorImp();
    }
}
