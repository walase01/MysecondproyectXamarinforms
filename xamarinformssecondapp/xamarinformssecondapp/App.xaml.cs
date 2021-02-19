using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace xamarinformssecondapp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new LoginTabbedPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
