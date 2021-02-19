using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace xamarinformssecondapp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Regist();
        }
        void Regist()
        {
            Register.GestureRecognizers.Add(new TapGestureRecognizer()
            {
                Command = new Command(async () =>
                {
                    await Navigation.PushAsync(new RegisterPage());
                })
            });
        }

        async private void Button_Clicked(object sender, EventArgs e)
        {
            if ((String.IsNullOrEmpty(Name_.Text) == false) & (String.IsNullOrEmpty(Password_.Text) == false))
            { 
                await DisplayAlert("Bienvenido",$"Hola {Name_.Text}","Ok");

                await Navigation.PushAsync(new MyMasterDetailPage());
            }
            else
            {
                await DisplayAlert("the name and email field are empty."," ","OK");
            }
        }
    }
}
