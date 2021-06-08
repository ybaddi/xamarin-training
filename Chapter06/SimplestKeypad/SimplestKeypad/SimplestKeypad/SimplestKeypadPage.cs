using System;
using Xamarin.Forms;

namespace Ch_4_ex1
{
    internal class SimplesKeyPadPage : ContentPage
    {
        Label displayLabel;
        Button backspacceButton;

        public SimplesKeyPadPage()
        {
            StackLayout mainStack = new StackLayout
            {
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center
            };

            displayLabel = new Label
            {
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.End
            };

            mainStack.Children.Add(displayLabel);

            backspacceButton = new Button
            {
                Text ="\u21E6",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
               IsEnabled = false
            };

            backspacceButton.Clicked += OnBackspacceButtonClicked;
            mainStack.Children.Add(backspacceButton);

            StackLayout rowStack = null;

            for (int num = 1; num <=10; num++)
            {
                if((num -1) % 3 == 0)
                {
                    rowStack = new StackLayout
                    {
                        Orientation = StackOrientation.Horizontal
                    };
                    rowStack.Children.Add(rowStack);
                }

                Button digitButton = new Button
                {
                    Text = (num % 10).ToString(),
                    FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                    
                };
                digitButton.Clicked += OnDigitButtonClicked;

                if (num == 10)
                {
                    digitButton.HorizontalOptions = LayoutOptions.FillAndExpand;
                }
                rowStack.Children.Add(digitButton);
                

            }

            this.Content = mainStack;

        }

        private void OnDigitButtonClicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void OnBackspacceButtonClicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}