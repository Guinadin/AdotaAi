using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Jober
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Detail : ContentPage
    {

        public Detail()
        {
            InitializeComponent();
            
        }

        private void btnRecusar_Clicked(object sender, EventArgs e)
        {
            {
                img.Source = "animal2";
                Nome.Text = "Betao";
                Raça.Text = "SRD MD PELO CURTO";
                Peso.Text = "Peso: 4 kg";
                Idade.Text = "Idade: 6 meses";
                Local.Text = "Petz Indaiatuba, INDAIATUBA, SP";
                Sobre.Text = "Sobre: Um pet amoroso e tranquilo mas bem divetido e alegre";

            }
        }    

        private async void btnAceitar_Clicked(object sender, EventArgs e)
        {
            try
            {
                await DisplayAlert("Parabens pela atitude", "Voçê quer adotar um animalzinho então colocaremos voce agora em um chat com o dono/ong dele", "OK");
                await Navigation.PushAsync(new Chat(), true);
            }

            catch (Exception x)
            {
                
                await DisplayAlert("opa algo deu errado", x.Message, "OK");

            }
        }
    }
}