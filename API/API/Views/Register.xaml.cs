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
    public partial class Register : ContentPage
    {
        public Register()
        {
            InitializeComponent();
        }

        private async void Registrar(object sender, EventArgs e)
        {
            await DisplayAlert("Registro", "Usuario registrado", "Aceptar");
            await App.MasterD.Detail.Navigation.PopAsync();
        }
    }
}