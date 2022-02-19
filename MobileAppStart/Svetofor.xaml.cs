using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileAppStart
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Svetofor : ContentPage
    {
        BoxView re;
        BoxView yello;
        BoxView gree;
        Button vkl;
        Button vekl;
        int nazata = 0; 
        public Svetofor()
        {

            re = new BoxView
            {

                CornerRadius = 100,
                WidthRequest = 200,
                HeightRequest = 150,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                BackgroundColor = Color.Gray,
            };
            yello = new BoxView
            {

                CornerRadius = 100,
                WidthRequest = 200,
                HeightRequest = 150,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                BackgroundColor = Color.Gray,

            };
            gree = new BoxView
            {

                CornerRadius = 100,
                WidthRequest = 200,
                HeightRequest = 150,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                BackgroundColor = Color.Gray,
            };
            vkl = new Button
            {
                Text = "Sisse",
                BackgroundColor = Color.Green,
                TextColor = Color.Black
            };
            vkl.Clicked += Vkl_Clicked;
            vekl = new Button
            {
                Text = "Välja",
                HorizontalOptions = LayoutOptions.End,
                BackgroundColor = Color.Red,
                TextColor = Color.Black
            };
            vekl.Clicked += Vekl_Clicked;
            FlexLayout knopki = new FlexLayout
            {
                Children = {vkl, vekl },
                JustifyContent = FlexJustify.SpaceEvenly
            };
            StackLayout st = new StackLayout
            {
                Children = {re,yello,gree, knopki}
            };
            Content = st;
            st.BackgroundColor = Color.PeachPuff;

        }

        private async void Vekl_Clicked(object sender, EventArgs e)
        {

            nazata = 1;
            while (nazata !=0)
            {
                re.BackgroundColor = Color.Gray;
                re.Opacity = 1;
                yello.BackgroundColor = Color.Gray;
                yello.Opacity = 1;
                gree.BackgroundColor = Color.Gray;
                gree.Opacity = 1;
            }
            

        }

        private async void Vkl_Clicked(object sender, EventArgs e)
        {
            nazata = 0;
            if (nazata == 1)
            {

            }
            else
            {
            while (nazata != 1)
            {
                re.BackgroundColor = Color.Red;
                re.Opacity = 1;
                yello.BackgroundColor = Color.Yellow;
                yello.Opacity = .2;
                gree.BackgroundColor = Color.Green;
                gree.Opacity = .2;
                await Task.Delay(3000);
                re.BackgroundColor = Color.Red;
                re.Opacity = .2;
                yello.BackgroundColor = Color.Yellow;
                yello.Opacity = 1;
                gree.BackgroundColor = Color.Green;
                gree.Opacity = .2;
                await Task.Delay(1000);
                re.BackgroundColor = Color.Red;
                re.Opacity = .2;
                yello.BackgroundColor = Color.Yellow;
                yello.Opacity = .2;
                gree.BackgroundColor = Color.Green;
                gree.Opacity = 1;
                await Task.Delay(3000);
                re.BackgroundColor = Color.Red;
                re.Opacity = .2;
                yello.BackgroundColor = Color.Yellow;
                yello.Opacity = 1;
                gree.BackgroundColor = Color.Green;
                gree.Opacity = .2;
                await Task.Delay(1000);
            }

            vkl.BackgroundColor = Color.White;
            }
            
        }
    }
}