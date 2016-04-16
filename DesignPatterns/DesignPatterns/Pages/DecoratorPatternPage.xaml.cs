using DesignPatterns.DecoratorPattern;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Xaml.Shapes;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace DesignPatterns.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class DecoratorPatternPage : Page
    {
        Random randomNumber;
        SolidColorBrush randomBrush;
        SolidColorBrush chartreuseBrush;

        public DecoratorPatternPage()
        {
            this.InitializeComponent();

            DisplayRectangles();
        }


        private void AddRectangleToStackPanel(IBaseRectangle br, string text = "")
        {
            Grid grid = new Grid();
            TextBlock tb = new TextBlock();

            tb.Text = text;
            tb.VerticalAlignment = VerticalAlignment.Bottom;
            tb.Foreground = new SolidColorBrush(Colors.White);
            tb.Margin = new Thickness(15);
            tb.TextWrapping = TextWrapping.WrapWholeWords;

            grid.Width = 250;
            grid.Height = 110;
            grid.Children.Add(br.CreateBaseRectangle());
            grid.Children.Add(tb);
            grid.HorizontalAlignment = HorizontalAlignment.Center;

            decoratorContent.Children.Add(grid);
        }

        private void DisplayRectangles()
        {
            decoratorContent.Children.Clear();

            randomNumber = new Random();
            chartreuseBrush = new SolidColorBrush(Colors.Chartreuse);
            IBaseRectangle baseRect = new BaseRectangle();

            // The base component interface
            AddRectangleToStackPanel(
                baseRect, 
                "The base component interface"
                );

            // The base component interface through the Stroke Decorator
            // with a Chartreuse stroke of random thickness
            AddRectangleToStackPanel(
                new StrokeDecorator(baseRect, chartreuseBrush, randomNumber.Next(10)), 
                "Stroke Decorator adding a chartreuse stroke of random thickness"
                );

            // The base component interface through the Fill Decorator
            // with a random fill color
            AddRectangleToStackPanel(
                new FillDecorator(baseRect, RandomColorBrush()), 
                "Fill Decorator adding a random fill color"
                );

            // The base component interface
            // through the Stroke Decorator with a random stroke of random thickness
            // through the Fill Decorator with a random fill color
            AddRectangleToStackPanel(
                new FillDecorator(new StrokeDecorator(baseRect, RandomColorBrush(), randomNumber.Next(10)), RandomColorBrush()), 
                "Stroke Decorator with random color of random thickness, passed through Fill Decorator with random fill color"
                );

            // The base component
            // through the Fill Decorator with a random fill color
            // through the Stroke Decorator with a random stroke of random thickness
            FillDecorator fillDecorator = new FillDecorator(new BaseRectangle(), RandomColorBrush());
            AddRectangleToStackPanel(
                new StrokeDecorator(fillDecorator, RandomColorBrush(), randomNumber.Next(10)), 
                "Explicitely initiated Fill Decorator with random fill color, passed through Stroke Decorator with random color and random thickness"
                );

            // The base component interface
            // through the Stroke Decorator 
            // with a random stroke color and stroke thickness of 5
            AddRectangleToStackPanel(
                new StrokeDecorator(baseRect, RandomColorBrush(), 5), 
                ""
                );
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
