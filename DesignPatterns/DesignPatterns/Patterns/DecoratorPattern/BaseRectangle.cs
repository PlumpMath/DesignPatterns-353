using Windows.UI;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Shapes;

// Inspired by Judith Bishop's 2007 book C# 3.0 Design Patterns
namespace DesignPatterns.Patterns.DecoratorPattern
{
    public class BaseRectangle : IBaseRectangle
    {
        public Rectangle CreateBaseRectangle()
        {
            Rectangle rect = new Rectangle();

            rect.Fill = new SolidColorBrush(Colors.Pink);
            rect.Margin = new Windows.UI.Xaml.Thickness(5);

            return rect;
        }
    }
}
