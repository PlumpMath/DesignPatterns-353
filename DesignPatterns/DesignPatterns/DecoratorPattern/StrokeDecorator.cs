using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Shapes;

namespace DesignPatterns.DecoratorPattern
{
    class StrokeDecorator : IBaseRectangle
    {
        IBaseRectangle baseRect;
        SolidColorBrush strokeColorBrush;
        int strokeThickness;

        public StrokeDecorator(IBaseRectangle br, SolidColorBrush brush, int stroke)
        {
            baseRect = br;
            strokeColorBrush = brush;
            strokeThickness = stroke;
        }

        public Rectangle CreateBaseRectangle()
        {
            Rectangle r = baseRect.CreateBaseRectangle();
            r.Stroke = strokeColorBrush;
            r.StrokeThickness = strokeThickness;

            return r;
        }
    }
}
