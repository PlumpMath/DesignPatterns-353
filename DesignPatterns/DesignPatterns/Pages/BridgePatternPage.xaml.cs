using DesignPatterns.BridgePattern;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace DesignPatterns.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class BridgePatternPage : Page
    {
        public BridgePatternPage()
        {
            this.InitializeComponent();
            vOneTextBlock.Text = new Abstraction(new ImplementationV1()).GetVersionName();
            abstractionEllipse.Fill = new Abstraction(new ImplementationV1()).GetVersionColor();
        }

        private void SwitchButton_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            if (vOneTextBlock.Text == string.Empty)
            {
                vOneTextBlock.Text = new Abstraction(new ImplementationV1()).GetVersionName();
                abstractionEllipse.Fill = new Abstraction(new ImplementationV1()).GetVersionColor();
                vTwoTextBlock.Text = string.Empty;
            }
            else
            {
                vTwoTextBlock.Text = new Abstraction(new ImplementationV2()).GetVersionName();
                abstractionEllipse.Fill = new Abstraction(new ImplementationV2()).GetVersionColor();
                vOneTextBlock.Text = string.Empty;
            }
        }
    }
}
