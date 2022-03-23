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
    public partial class CurrentCharacterPage : ContentPage
    {
        public Characters characters { get; set; }
        public CurrentCharacterPage(Characters character)
        {
            InitializeComponent();
            characters = character;
            this.BindingContext = this;
        }
        protected override void OnAppearing()
        {
            characterPhoto.Source = characters.fullImage;
            nameCharacter.Text = characters.name;
            visionCharacter.Text = characters.vision;
            weaponCharacter.Text = characters.weapon;
            this.BindingContext = this;
            base.OnAppearing();
        }
    }
    
}