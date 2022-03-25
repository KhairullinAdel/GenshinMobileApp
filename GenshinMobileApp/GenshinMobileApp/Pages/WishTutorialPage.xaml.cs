using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;

namespace GenshinMobileApp.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WishTutorialPage : ContentPage
    {
        public WishTutorialPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            
        }

        private async void ShowWishes(object sender, EventArgs e)
        {
            if (LinkHere.Text.ToString().Contains("https://webstatic-sea.mihoyo.com/") )
            {
                await Launcher.OpenAsync(new Uri(LinkHere.Text));
            }
            else
            {
                LinkHere.Text = "";
                LinkHere.Placeholder = "Неверная ссылка";
            }
        }

        private void ClearEntry(object sender, EventArgs e)
        {
            LinkHere.Text = "";
            LinkHere.Placeholder = "Введите текст здесь";
        }
    }
}