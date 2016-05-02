using Windows.UI.Xaml.Media;

// Inspired by Judith Bishop's 2007 book C# 3.0 Design Patterns
namespace DesignPatterns.Patterns.BridgePattern
{
    public interface Bridge
    {
        string GetVersionNameImp();

        SolidColorBrush GetVersionColorImp();
    }
}
