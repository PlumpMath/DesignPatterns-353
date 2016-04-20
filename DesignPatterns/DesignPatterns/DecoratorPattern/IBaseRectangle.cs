using Windows.UI.Xaml.Shapes;

// Inspired by Judith Bishop's 2007 book C# 3.0 Design Patterns
namespace DesignPatterns.DecoratorPattern
{
    public interface IBaseRectangle
    {
        Rectangle CreateBaseRectangle();
    }
}
