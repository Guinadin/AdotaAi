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
    public partial class TrocarSenha : ContentPage
    {
        public TrocarSenha()
        {
            InitializeComponent();
        }

        private async void btnTrocaSenha_Clicked(object sender, EventArgs e)
        {
            try
            {
                
                await DisplayAlert("Troca de Senha", "Sucesso, foi enviado para seu email o link para troca de senha", "OK");
                await Navigation.PushModalAsync(new MainPage(), true);
            }

            catch(Exception x)
            {
                await DisplayAlert("Erro, mas nao se preocupe estamos arrumando ja", x.Message, "OK");
            }
        }
    }
}