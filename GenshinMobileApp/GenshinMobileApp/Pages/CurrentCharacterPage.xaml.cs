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
        public CurrentCharacterPage()
        {
            InitializeComponent();
            var listCharacters = Case.characters;
        }
        public static void GetCharacter()
        {

        }
    }
    
}