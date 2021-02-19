using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace xamarinformssecondapp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegisterPage : ContentPage
    {
        public RegisterPage()
        {
            InitializeComponent();
        }

        async private void Button_Clicked(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Name_.Text) == false)
            {
                if (String.IsNullOrEmpty(Email_.Text) == false)
                {
                    if (String.IsNullOrEmpty(Password_.Text) == false)
                    {
                        if(String.IsNullOrEmpty(ConfirmPassword.Text) == false)
                        {
                            if (String.Equals(Password_.Text, ConfirmPassword.Text))
                            {
                                await DisplayAlert("Welcome", $"Hola {Name_.Text}", "Ok");
                                await Navigation.PushAsync(new MyMasterDetailPage());
                            }
                            else
                            {
                                await DisplayAlert("the password and confirm password are different.", " ", "Ok");
                            }                                                       
                        }
                    }
                } 
            }
            else
            {
                await DisplayAlert("the name, email, password and confirm password fields are empty", " ", "Ok");
            }
        }
    }
}