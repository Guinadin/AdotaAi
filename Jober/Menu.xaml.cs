using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Jober.View;
using Plugin.FilePicker;

namespace Jober.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TesteMenu : FlyoutPage
	{
        

        public TesteMenu()
		{
			InitializeComponent();
		
			Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(Detail)));

		}

        

        private void Perfil(object sender, System.EventArgs e)
		{
			
			Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(PerfilPessoa)));
			IsPresented = false;
		}

		private void PerfilEmpresa(object sender, System.EventArgs e)
		{

			Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(PerfilEmpresa)));
			IsPresented = false;
		}

		private void Home(object sender, System.EventArgs e)
		{
			Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(Detail)));
			IsPresented = false;
		}
		private void Trocarsenha(object sender, System.EventArgs e)
		{

			Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(TrocarSenhaMenu)));
			IsPresented = false;
		}

        private void Retornar_Clicked(object sender, EventArgs e)
        {
			                                                     //retorna para login
			//await Navigation.PopAsync();

			Navigation.PushModalAsync(new MainPage(), true);
			
		}

        private void Chat(object sender, EventArgs e)
        {
			Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(Chat)));
			IsPresented = false;
		}
		private void Di(object sender, EventArgs e)
		{
			Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(Divulgar)));
			IsPresented = false;
		}

		private async void Site(object sender, EventArgs e)
		{
			await DisplayAlert("Contato", "WhatsApp: (19)98304-1234 \n\nEmail: Adotaai@gmail.com", "OK");
		}


		private async void imageP_Clicked(object sender, EventArgs e)
        {
			var img = await CrossFilePicker.Current.PickFile();

			if (img != null)
			{
				
				imageP.Source = img.FilePath;

			}
		}
    }
	



	
}