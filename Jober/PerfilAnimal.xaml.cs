using Plugin.FilePicker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Jober.View;

namespace Jober
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PerfilEmpresa : ContentPage
    {
        

        public PerfilEmpresa()
        {
            InitializeComponent();
        }

        

        private async void ImageButton_Clicked(object sender, EventArgs e)
        {
            var img = await CrossFilePicker.Current.PickFile();

            if(img != null)
            {
                btnMsg.Source = img.FilePath;
                
                
            }
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new EditarPerfil(), true);
        }
    }
}