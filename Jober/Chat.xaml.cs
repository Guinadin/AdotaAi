using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace Jober
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Chat : ContentPage
    {

        public Chat()
        {
            InitializeComponent();

        }

        private async void ImageButton_Clicked(object sender, EventArgs e)
        {
            try
            {
                var gg = new Label
                {
                    Text = txt.Text,
                    TextColor = Color.Black,
                    HorizontalTextAlignment = TextAlignment.Start,
                    
                    FontSize = 18,
                    FontFamily = "{StaticResource SpecialFont}",
                    HorizontalOptions = LayoutOptions.StartAndExpand,
                    Margin = 10
                };
                Frame frame = new Frame
                {
                    BackgroundColor = Color.LightGreen,
                    BorderColor = Color.Gray,
                    CornerRadius = 10,
                    Padding = 0,
                    HasShadow = true,
                    HorizontalOptions = LayoutOptions.StartAndExpand,
                    Margin = 0,
                    Content = gg
                };

                Tela.Children.Add(frame);
                txt.Text = "";

                if (gg.Text == "Boa Tarde")
                {
                    Frame frame2 = new Frame
                    {
                        BackgroundColor = Color.LightGray,
                        BorderColor = Color.Gray,
                        CornerRadius = 10,
                        Padding = 0,
                        HasShadow = true,
                        HorizontalOptions = LayoutOptions.EndAndExpand,
                        Margin = 0,
                        Content = new Label
                        {

                            Text = "Olá tudo bem ? Voçê então quer adotar nosso animalzinho ?",
                            TextColor = Color.Black,
                            HorizontalTextAlignment = TextAlignment.Start,
                            
                            FontSize = 18,
                            FontFamily = "{StaticResource SpecialFont}",
                            HorizontalOptions = LayoutOptions.EndAndExpand,
                            Margin = 10
                        }

                    };
                    Tela.Children.Add(frame2);
                }

                if (gg.Text == "Exatamente")
                {
                    Frame frame3 = new Frame
                    {
                        BackgroundColor = Color.LightGray,
                        BorderColor = Color.Gray,
                        CornerRadius = 10,
                        Padding = 0,
                        HasShadow = true,
                        HorizontalOptions = LayoutOptions.EndAndExpand,
                        Margin = 0,
                        Content = new Label
                        {

                            Text = "Maravilha ele precisa muito de um lar",
                            TextColor = Color.Black,
                            HorizontalTextAlignment = TextAlignment.Start,

                            FontSize = 18,
                            FontFamily = "{StaticResource SpecialFont}",
                            HorizontalOptions = LayoutOptions.EndAndExpand,
                            Margin = 10
                        }

                    };
                    Tela.Children.Add(frame3);
                }

                if (gg.Text == "Que bom que posso ajudar entao")
                {
                    Frame frame4 = new Frame
                    {
                        BackgroundColor = Color.LightGray,
                        BorderColor = Color.Gray,
                        CornerRadius = 10,
                        Padding = 0,
                        HasShadow = true,
                        HorizontalOptions = LayoutOptions.EndAndExpand,
                        Margin = 0,
                        Content = new Label
                        {

                            Text = "Iremos verificar seu perfil e retornamos por ligação",
                            TextColor = Color.Black,
                            HorizontalTextAlignment = TextAlignment.Start,

                            FontSize = 18,
                            FontFamily = "{StaticResource SpecialFont}",
                            HorizontalOptions = LayoutOptions.EndAndExpand,
                            Margin = 10
                        }

                    };
                    Tela.Children.Add(frame4);


                }

                if (gg.Text == "Perfeito")
                {
                    Frame frame6 = new Frame
                    {
                        BackgroundColor = Color.LightGray,
                        BorderColor = Color.Gray,
                        CornerRadius = 10,
                        Padding = 0,
                        HasShadow = true,
                        HorizontalOptions = LayoutOptions.EndAndExpand,
                        Margin = 0,
                        Content = new Label
                        {

                            Text = "O resto das informações de adoção te mandarei no e-mail",
                            TextColor = Color.Black,
                            HorizontalTextAlignment = TextAlignment.Start,

                            FontSize = 18,
                            FontFamily = "{StaticResource SpecialFont}",
                            HorizontalOptions = LayoutOptions.EndAndExpand,
                            Margin = 10
                        }

                    };
                    Tela.Children.Add(frame6);
                }

                if (gg.Text == "Ok estarei no aguardo")
                {
                    Frame frame7 = new Frame
                    {
                        BackgroundColor = Color.LightGray,
                        BorderColor = Color.Gray,
                        CornerRadius = 10,
                        Padding = 0,
                        HasShadow = true,
                        HorizontalOptions = LayoutOptions.EndAndExpand,
                        Margin = 0,
                        Content = new Label
                        {

                            Text = "até 👍",
                            TextColor = Color.Black,
                            HorizontalTextAlignment = TextAlignment.Start,

                            FontSize = 18,
                            FontFamily = "{StaticResource SpecialFont}",
                            HorizontalOptions = LayoutOptions.EndAndExpand,
                            Margin = 10
                        }

                    };
                    Tela.Children.Add(frame7);
                }
            }
            

            catch(Exception x)
            {
                await DisplayAlert("opa algo deu errado", x.Message, "OK");
                
            }

        }

        
    }
}