using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace GenshinMobileApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private async void GuidesButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Pages.CharacterListPage());
        }

        private async void WishesButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Pages.WishTutorialPage());
        }
    }
}
