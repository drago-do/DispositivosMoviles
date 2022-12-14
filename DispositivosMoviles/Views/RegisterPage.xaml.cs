using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using DispositivosMoviles.ViewModels;
using DispositivosMoviles.Views;

namespace DispositivosMoviles
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegisterPage : ContentPage
    {
        public RegisterPage()
        {
            InitializeComponent();
            BindingContext = new RegisterViewModelDrago();
        }
        private async void btnUserListPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new UsersListPage());
        }
    }
}