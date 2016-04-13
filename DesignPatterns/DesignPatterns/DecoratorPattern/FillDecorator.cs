using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Shapes;

namespace DesignPatterns.DecoratorPattern
{
    class FillDecorator : IBaseRectangle
    {
        IBaseRectangle baseRect;
        SolidColorBrush fillColorBrush;

        public FillDecorator(IBaseRectangle br, SolidColorBrush brush)
        {
            baseRect = br;
            fillColorBrush = brush;
        }

        public Rectangle CreateBaseRectangle()
        {
            Rectangle r = baseRect.CreateBaseRectangle();
            r.Fill = fillColorBrush;
            return r;
        }
    }
}
