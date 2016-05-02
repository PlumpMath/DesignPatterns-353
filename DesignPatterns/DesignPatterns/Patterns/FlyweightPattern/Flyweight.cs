using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;

// Inspired by Judith Bishop's 2007 book C# 3.0 Design Patterns
namespace DesignPatterns.Patterns.FlyweightPattern
{
    public struct Flyweight : IFlyweight
    {
        // intrinsic state
        FontIcon icon;

        public void Display(Canvas canvas, int x, int y)
        {
            canvas.Children.Add(icon);
            Canvas.SetLeft(icon, x);
            Canvas.SetTop(icon, y);
        }

        public void Load(string glyph, SolidColorBrush brush)
        {
            icon = new FontIcon();
            icon.FontSize = 45;
            icon.Foreground = brush;
            icon.Glyph = glyph;
        }
    }
}
