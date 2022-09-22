using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DispositivosMoviles
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnRegistro_Clicked(object sender,EventArgs e)
        {
            await Navigation.PushAsync(new RegisterPage());
        }
<<<<<<< HEAD
        private async void btnInicioSesion_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LoginPage());
        }
=======
>>>>>>> 1a37c9176e166acc8224ec8b26c4213cc98853eb
    }
}
