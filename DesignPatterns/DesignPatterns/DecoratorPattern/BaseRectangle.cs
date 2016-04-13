using Windows.UI;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Shapes;

namespace DesignPatterns.DecoratorPattern
{
    public class BaseRectangle : IBaseRectangle
    {
        public Rectangle CreateBaseRectangle()
        {
            Rectangle rect = new Rectangle();

            rect.Width = 200;
            rect.Height = 60;
            rect.Fill = new SolidColorBrush(Colors.Pink);
            rect.Margin = new Windows.UI.Xaml.Thickness(5);

            return rect;
        }
    }
}
