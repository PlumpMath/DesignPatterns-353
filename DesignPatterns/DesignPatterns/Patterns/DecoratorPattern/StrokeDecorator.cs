using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Shapes;

// Inspired by Judith Bishop's 2007 book C# 3.0 Design Patterns
namespace DesignPatterns.Patterns.DecoratorPattern
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
