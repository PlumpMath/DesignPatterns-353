using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;

// Inspired by Judith Bishop's 2007 book C# 3.0 Design Patterns
namespace DesignPatterns.Patterns.FlyweightPattern
{
    public interface IFlyweight
    {
        void Load(string glyph, SolidColorBrush brush);

        void Display(Canvas canvas, int x, int y);
    }
}
