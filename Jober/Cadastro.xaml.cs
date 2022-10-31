using Jober.View;
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
    public partial class Cadastro : ContentPage
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private async void btnCadastrar_Clicked(object sender, EventArgs e)
        {
            if(txtNome.Text == null || txtSobreNome.Text == null || txtEmail.Text == null || txtTelefone.Text == null || txtCPF.Text == ""|| txtCNPJ.Text == "")
            {
                await DisplayAlert("Erro", "Preencher todos os campos", "OK");
            }
            else if(CPF.IsChecked == true)
            {
                await Navigation.PushModalAsync(new TesteMenu(), true);
            }
            else if(CNPJ.IsChecked == true)
            {
                await Navigation.PushModalAsync(new Divulgar(), true);
            }


            
        }

        private void CPF_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (CPF.IsChecked == true)
            {
                
                CNPJ.IsChecked = false;
                txtCPF.IsVisible = true;
            }
            else if(CPF.IsChecked == false)
            {
                CNPJ.IsChecked = true;
                txtCPF.IsVisible = false;
            }
        }

        private void CNPJ_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {

            if (CNPJ.IsChecked == true)
            {
                CPF.IsChecked = false;
                txtCNPJ.IsVisible = true;
            }
            else if (CNPJ.IsChecked == false)
            {
                CPF.IsChecked = true;
                txtCNPJ.IsVisible = false;
            }
        }

        private void Masculino_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (Masculino.IsChecked == true)
            {

                Feminino.IsChecked = false;
                
            }
            else if (Masculino.IsChecked == false)
            {
                Feminino.IsChecked = true;
                
            }
        }

        private void Feminino_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (Feminino.IsChecked == true)
            {

                Masculino.IsChecked = false;

            }
            else if (Feminino.IsChecked == false)
            {
                Masculino.IsChecked = true;

            }
        }

        
    }
}