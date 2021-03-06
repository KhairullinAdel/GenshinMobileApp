using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GenshinMobileApp.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CharacterListPage : ContentPage
    {
        public CharacterListPage()
        {
            InitializeComponent();
        }

        private async void CharacterGuideChoose(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CurrentCharacterPage());
        }
    }
}