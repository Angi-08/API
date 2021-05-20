using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace API.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private async void Loguearse(object sender, EventArgs e)
        {
            await DisplayAlert("Login", "Sesión iniciada", "Aceptar");
            await App.MasterD.Detail.Navigation.PopAsync();
        }

        private async void Registrarse(object sender, EventArgs e)
        {
            await App.MasterD.Detail.Navigation.PushAsync(new Register());
        }
    }
}