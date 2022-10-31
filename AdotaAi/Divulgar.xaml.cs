using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Jober.View;
using Plugin.FilePicker;

namespace Jober
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Divulgar : ContentPage
    {
        public Divulgar()
        {
            InitializeComponent();
        }

        

        private async void imgD_Clicked(object sender, EventArgs e)
        {
            var img = await CrossFilePicker.Current.PickFile();

            if (img != null)
            {
                imgD.Source = img.FilePath;
                

            }
        }

        private async void btnDivulgar_Clicked(object sender, EventArgs e)
        {
            /*var emprego = new Emprego
            {
                cargo = txtCargo.Text,
                salario = txtSalario.Text,
                horario = txtHorario.Text,
                beneficio = txtBeneficios.Text,
                direitos = txtDireitos.Text,
                imagem = imgD.Source
            };

            var detail = new Detail();
            detail.BindingContext = emprego;

            await Navigation.PushAsync(detail);*/
            if (txtRaça.Text == null || txtEspecie.Text == null || txtPeso.Text == null || txtIdade.Text == null || txtSobre.Text == null || txtLocal.Text == null)
            {
                await DisplayAlert("Erro", "Preencher todos os campos", "OK");
            }
            else
            {
                await Navigation.PushModalAsync(new TesteMenu(), true);
            }
            
        }
    }
}