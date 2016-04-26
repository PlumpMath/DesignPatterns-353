using System.Linq;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;
using DesignPatterns.ProxyPattern;

namespace DesignPatterns.Pages
{
    public sealed partial class ProxyPatternPage : Page
    {
        ProxySystem.Proxy proxy;

        public ProxyPatternPage()
        {
            this.InitializeComponent();
            proxy = new ProxySystem.Proxy();

            FocusTextBox(choosePwTxtBx);
        }


        private void FocusTextBox(TextBox tb)
        {
            tb.Text = string.Empty;
            tb.Focus(FocusState.Programmatic);
        }

        private void AddToDisplayText(string text, SolidColorBrush brush)
        {
            resultText.Text += ("\n" + text);
            resultRect.Fill = brush;
        }


        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            proxy.Reset();

            enterPwTxtBx.Text = string.Empty;
            chooseNmTxtBx.Text = string.Empty;
            choosePwTxtBx.Text = string.Empty;
            addTxtBx.Text = string.Empty;

            resultText.Text = "";

            VisualStateManager.GoToState(this, "ChoosePwTxtBxEnabled", true);
            VisualStateManager.GoToState(this, "SetPwBtnDisabled", true);
            VisualStateManager.GoToState(this, "CheckPwBtnDisabled", true);
            VisualStateManager.GoToState(this, "AddBtnDisabled", true);
            VisualStateManager.GoToState(this, "ResultGridCollapsed", true);

            FocusTextBox(choosePwTxtBx);
        }


        private void SetPwBtn_Click(object sender, RoutedEventArgs e)
        {
            proxy.Register(choosePwTxtBx.Text, chooseNmTxtBx.Text);

            VisualStateManager.GoToState(this, "SetPwBtnDisabled", true);
            VisualStateManager.GoToState(this, "EnterPwTxtBxEnabled", true);
            
            FocusTextBox(enterPwTxtBx);
        }


        private void CheckPwBtn_Click(object sender, RoutedEventArgs e)
        {
            VisualStateManager.GoToState(this, "ResultGridVisible", true);

            if (proxy.Authenticate(enterPwTxtBx.Text))
            {
                AddToDisplayText(
                    "Password authenticated, " + 
                    chooseNmTxtBx.Text + 
                    "! Your name and password have been stored in the private Subject class by way of the public Proxy class.", 
                    new SolidColorBrush(Colors.Green)
                    );

                VisualStateManager.GoToState(this, "AddTxtBxEnabled", true);
            }
            else
            {
                AddToDisplayText(
                    "Wrong password. Try again.", 
                    new SolidColorBrush(Colors.Red)
                    );

                VisualStateManager.GoToState(this, "EnterPwTxtBxEnabled", true);
            }
        }


        private void TxtBx_TextChanging(TextBox sender, TextBoxTextChangingEventArgs args)
        {
            if (choosePwTxtBx.Text.Count() > 3 && chooseNmTxtBx.Text.Count() > 0)
                VisualStateManager.GoToState(this, "SetPwBtnEnabled", true);
            else if (sender == choosePwTxtBx)
                VisualStateManager.GoToState(this, "SetPwBtnDisabled", true);

            if (enterPwTxtBx.Text.Count() > 3)
                VisualStateManager.GoToState(this, "CheckPwBtnEnabled", true);
            else if (sender == enterPwTxtBx)
                VisualStateManager.GoToState(this, "CheckPwBtnDisabled", true);

            if (addTxtBx.Text.Count() > 0)
                VisualStateManager.GoToState(this, "AddBtnEnabled", true);
            else if (sender == addTxtBx)
                VisualStateManager.GoToState(this, "AddBtnDisabled", true);
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            proxy.Add(addTxtBx.Text);

            AddToDisplayText( addTxtBx.Text +
                   " has been added to the private Subject class by way of the public Proxy class.",
                   new SolidColorBrush(Colors.Blue)
                   );
        }
    }
}
