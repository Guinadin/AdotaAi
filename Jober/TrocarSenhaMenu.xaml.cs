using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Jober
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TrocarSenhaMenu : ContentPage
    {
        public TrocarSenhaMenu()
        {
            InitializeComponent();
        }

        private async void btnTrocaSenha_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Senha", "Senha alterada com sucesso", "OK");
        }
    }
}