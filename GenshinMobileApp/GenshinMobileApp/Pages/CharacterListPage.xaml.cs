using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using GenshinMobileApp.DB;

namespace GenshinMobileApp.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CharacterListPage : ContentPage
    {
        public List<Characters> listCharacters = Case.characters;
        public CharacterListPage()
        {
            InitializeComponent();

            this.BindingContext = this;
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private async void CharactersList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Characters selectedCharacter = (Characters)e.SelectedItem;
            CurrentCharacterPage currentCharacterPage = new CurrentCharacterPage(selectedCharacter);
            currentCharacterPage.BindingContext = selectedCharacter;
            await Navigation.PushAsync(new CurrentCharacterPage(selectedCharacter));
        }

        protected override void OnAppearing()
        {
            CharacterList.ItemsSource = listCharacters;
            
            base.OnAppearing();
        }
        
    }
}