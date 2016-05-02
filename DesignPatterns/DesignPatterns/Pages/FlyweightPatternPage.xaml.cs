using DesignPatterns.Patterns.FlyweightPattern;
using Windows.UI.Xaml.Controls;
using DesignPatterns.Data;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace DesignPatterns.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class FlyweightPatternPage : Page
    {
        const int iconWidthHeight = 65;
        const int iconsPerRow = 6;
        const int groupRowHeight = 85;

        IconData iconData = new IconData();

        public FlyweightPatternPage()
        {
            this.InitializeComponent();

            int x;
            int y = 0;
            int groupCounter = 0;

            FlyweightFactory album = new FlyweightFactory();

            foreach (string[] iconRefGroup in iconData.IconRefGroups)
            {
                x = 0;
                y = y + groupRowHeight;

                Canvas.SetTop(GroupTitle(groupCounter), y);

                y = y + groupRowHeight / 2;

                int itemCounter = 1;

                for (var i = 0; i < iconRefGroup.Length; i++)
                {
                    album[iconRefGroup[i]].Load(iconRefGroup[i], iconData.IconGroupBrushes[groupCounter]);
                    album[iconRefGroup[i]].Display(flyweightCanvas, x, y);

                    x = x + iconWidthHeight;

                    if (itemCounter % iconsPerRow == 0)
                    {
                        y = y + iconWidthHeight;
                        x = 0;
                    }

                    itemCounter++;                     
                }

                groupCounter++;
            }

            // set the canvas height to accommodate
            flyweightCanvas.Height = y + iconWidthHeight;
        } 

        private TextBlock GroupTitle(int group)
        {
            TextBlock titleTextBlock = new TextBlock();
            titleTextBlock.Text = iconData.IconGroupTitles[group];
            titleTextBlock.FontSize = 26;
            flyweightCanvas.Children.Add(titleTextBlock);

            return titleTextBlock;
        }
    }
}
