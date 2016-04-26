using DesignPatterns.CompositePattern;
using System.Collections.Generic;
using System.Linq;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Shapes;
using Windows.UI;
using System.Reflection;


namespace DesignPatterns.Pages
{
    public sealed partial class CompositePatternPage : Page
    {
        IComponent<Rectangle> reds;
        IComponent<Rectangle> blues;
        IComponent<Rectangle> yellows;

        public CompositePatternPage()
        { 
            this.InitializeComponent();

            InitializeColorComponents();
        }

        private void InitializeColorComponents()
        {
            reds = new Composite<Rectangle>();
            blues = new Composite<Rectangle>();
            yellows = new Composite<Rectangle>();

            var AllColors = typeof(Colors).GetRuntimeProperties().Select(x => new { Color = (Color)x.GetValue(null), Name = x.Name });

            foreach (var color in AllColors)
            {
                if (color.Name.ToLower().Contains("blue"))
                    blues.Add(new Component<Rectangle>(CreateRectItem(new SolidColorBrush(color.Color))));
                else if (color.Name.ToLower().Contains("yellow"))
                    yellows.Add(new Component<Rectangle>(CreateRectItem(new SolidColorBrush(color.Color))));
                else if (color.Name.ToLower().Contains("red"))
                    reds.Add(new Component<Rectangle>(CreateRectItem(new SolidColorBrush(color.Color))));
            }

            redGridView.ItemsSource = CreateRectList(reds);
            blueGridView.ItemsSource = CreateRectList(blues);
            yellowGridView.ItemsSource = CreateRectList(yellows);
        }


        private List<Rectangle> CreateRectList(IComponent<Rectangle> composite)
        {
            List<Rectangle> list = new List<Rectangle>();

            foreach (Component<Rectangle> component in composite.ItemsList)
                list.Add(component.RectangleItem);

            return list;
        }


        private Rectangle CreateRectItem(SolidColorBrush brush)
        {
            Rectangle rect = new Rectangle();
            rect.Width = 60;
            rect.Height = 60;
            rect.Fill = brush;

            return rect;
        }

        private void RemoveButton_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            Button btn = sender as Button; 

            if (btn == blueRemoveButton && blueGridView.SelectedIndex > -1)
            {                
                blues.ItemsList.RemoveAt(blueGridView.SelectedIndex);
                blueGridView.ItemsSource = CreateRectList(blues);
            } else if (btn == redRemoveButton && redGridView.SelectedIndex > -1)
            {
                reds.ItemsList.RemoveAt(redGridView.SelectedIndex);
                redGridView.ItemsSource = CreateRectList(reds);
            }
            else
            {
                yellows.ItemsList.RemoveAt(yellowGridView.SelectedIndex);
                yellowGridView.ItemsSource = CreateRectList(yellows);
            }
        }

        private void GridView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            GridView gv = sender as GridView;

            if (gv.SelectedIndex > -1)
            {
                if (gv == blueGridView)
                    blueRemoveButton.IsEnabled = true;
                else if (gv == redGridView)
                    redRemoveButton.IsEnabled = true;
                else
                    yellowRemoveButton.IsEnabled = true;
            }
            else
            {
                if (gv == blueGridView)
                    blueRemoveButton.IsEnabled = false;
                else if (gv == redGridView)
                    redRemoveButton.IsEnabled = false;
                else
                    yellowRemoveButton.IsEnabled = false;
            }   
        }

        private void ResetButton_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            InitializeColorComponents();
        }
    }
}
