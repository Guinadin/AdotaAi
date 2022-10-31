using Plugin.FilePicker;
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
    public partial class PerfilPessoa : ContentPage
    {
        public PerfilPessoa()
        {
            InitializeComponent();
        }

        

        

        private async void btnP_Clicked(object sender, EventArgs e)
        {
            

        }

        private async void imageE_Clicked(object sender, EventArgs e)
        {
            var img = await CrossFilePicker.Current.PickFile();

            if (img != null)
            {

                imageE.Source = img.FilePath;

            }
        }

        private void btnEd_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new EditarPerfil(), true);
        }
    }
}