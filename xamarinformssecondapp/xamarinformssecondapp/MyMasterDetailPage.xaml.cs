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
    public partial class MyMasterDetailPage : MasterDetailPage
    {
        public MyMasterDetailPage()
        {
            InitializeComponent();
            LlmarPuntos();
        }
        void LlmarPuntos()
        {
            Puntos.GestureRecognizers.Add(new TapGestureRecognizer()
            {
                Command = new Command(async () =>
                {
                    await Navigation.PushAsync(new PuntosExtrasPage());
                })
            });
        }
    
    }
}