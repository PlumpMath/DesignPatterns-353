using DesignPatterns.DecoratorPattern;
using System;
using Windows.UI;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Shapes;


namespace DesignPatterns
{
    public sealed partial class MainPage : Page
    {
        Random randomNumber;
        SolidColorBrush randomBrush;
        SolidColorBrush chartreuseBrush;

        public MainPage()
        {
            this.InitializeComponent();

            DisplayRectangles();
        }

        private Rectangle CreatedRectangle(IBaseRectangle br)
        {
            return br.CreateBaseRectangle();
        }

        private void DisplayRectangles()
        {
            decoratorContent.Children.Clear();

            randomNumber = new Random();
            chartreuseBrush = new SolidColorBrush(Colors.Chartreuse);
            IBaseRectangle baseRect = new BaseRectangle();

            // The base component interface
            decoratorContent.Children.Add(CreatedRectangle(baseRect));

            // The base component interface through the Stroke Decorator
            // with a Chartreuse stroke of random thickness
            decoratorContent.Children.Add(
                CreatedRectangle(new StrokeDecorator(baseRect, chartreuseBrush, randomNumber.Next(10))));

            // The base component interface through the Fill Decorator
            // with a random fill color
            decoratorContent.Children.Add(CreatedRectangle(new FillDecorator(baseRect, RandomColorBrush())));

            // The base component interface
            // through the Stroke Decorator with a random stroke of random thickness
            // through the Fill Decorator with a random fill color
            decoratorContent.Children.Add(CreatedRectangle(new FillDecorator(new StrokeDecorator(baseRect, RandomColorBrush(), randomNumber.Next(10)), RandomColorBrush())));

            // The base component
            // through the Fill Decorator with a random fill color
            // through the Stroke Decorator with a random stroke of random thickness
            FillDecorator fillDecorator = new FillDecorator(new BaseRectangle(), RandomColorBrush());
            decoratorContent.Children.Add(CreatedRectangle(new StrokeDecorator(fillDecorator, RandomColorBrush(), randomNumber.Next(10))));

            // The base component interface
            // through the Stroke Decorator 
            // with a random stroke color and stroke thickness of 5
            decoratorContent.Children.Add(CreatedRectangle(new StrokeDecorator(baseRect, RandomColorBrush(), 5)));
        }


        private SolidColorBrush RandomColorBrush()
        {

            randomBrush = new SolidColorBrush(
                Color.FromArgb(
                    255,
                    (byte)randomNumber.Next(255),
                    (byte)randomNumber.Next(255),
                    (byte)randomNumber.Next(255)
                    ));


            return randomBrush;
        }

        private void DecoratorResetButton_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            DisplayRectangles();
        }
    }
}
