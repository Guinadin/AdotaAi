using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Jober.View;


namespace Jober
{

    public partial class MainPage : ContentPage
    {
       
        public MainPage()
        {

            InitializeComponent();
            

        }

        

        private async void btnLogar_Clicked(object sender, EventArgs e)
        {
            //Navigation.PushAsync(new TesteMenu(), true);
            if(txtEmailL.Text == "gui.nadin@hotmail.com")
            {
                if(txtSenhaL.Text == "1234")
                {
                    await Navigation.PushModalAsync(new TesteMenu(), true);
                }
                else
                {
                    await DisplayAlert("Erro", "Senha Incorreta", "OK");
                }
            }
            else
            {
                await DisplayAlert("Erro", "Email Incorreto", "OK");
            }
           

           
        }

        private void btnCadastro_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Cadastro(), true);
        }

        private void btnEsquecersenha_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new TrocarSenha(), true);
        }
    }
}
