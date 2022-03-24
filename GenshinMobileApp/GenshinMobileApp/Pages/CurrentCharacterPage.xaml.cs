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
            NavigationPage.SetHasNavigationBar(this, false);
        }
        protected override void OnAppearing()
        {
            characterPhoto.Source = characters.fullImage;
            nameCharacter.Text = characters.name;
            visionCharacter.Text = characters.vision;
            weaponCharacter.Text = characters.weapon;
            this.BindingContext = this;
            base.OnAppearing();
            ArtifactsList();
        }
        private void ArtifactsList()
        {
            if (characters.vision == "Pyro")
                kubok.Text = "PYRO damage bonus";
            else if (characters.vision == "Cryo")
                kubok.Text = "CRYO damage bonus";
            else if (characters.vision == "Anemo")
                kubok.Text = "ANEMO damage bonus";
            else if (characters.vision == "Electro")
                kubok.Text = "ELECTRO damage bonus";
            else if (characters.vision == "Geo")
                kubok.Text = "GEO damage bonus";
            else if ((characters.vision == "Electro" && characters.weapon == "Claymore") || 
                (characters.vision == "Cryo" && characters.weapon == "Claymore"))
                kubok.Text = "PHYS damage bonus";           
            
            List<string> dopStatts = new List<string>();
            dopStatts.Add("CRIT damage");
            dopStatts.Add("CRIT rate");
            dopStatts.Add("ATEKA bonus");
            dopStatts.Add("RECHARGE bonus");
        }

    }

}