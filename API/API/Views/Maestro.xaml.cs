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
    public partial class Maestro : ContentPage
    {
        public Maestro()
        {
            InitializeComponent();
        }

        private void IrLogin(object sender, EventArgs e)
        {
            App.MasterD.IsPresented = false;
            App.MasterD.Detail.Navigation.PushAsync(new Login());
        }
    }
}