using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using DispositivosMoviles.Models;
using DispositivosMoviles.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DispositivosMoviles.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UsersListPage : ContentPage
    {
        public UsersListPage()
        {
            InitializeComponent();
            BindingContext = new UserListViewModel();

        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            ListViewUser.ItemsSource = await App.Database.GetTodoModel();
        }

        //Metodo para eliminar un usuarios, se llama cuando se hace click en el boton eliminar
        private async void BtnDelete_Clicked(object sender, EventArgs e)
        {
            if (await DisplayAlert("Confirmacion", "¿Estas seguro eliminar este usuario?", "Si", "No"))
            {
                var item = (UserDrago)(sender as MenuItem).CommandParameter;
                var result = await App.Database.DeleteUserAsync(item);
                if (result == 1)
                {
                    ListViewUser.ItemsSource = await App.Database.GetTodoModel();
                }
            }

        }

        private async void BtnUpdate_Clicked(object sender, EventArgs e)
        {
            var item = (UserDrago)(sender as MenuItem).CommandParameter;
            var result = await App.Database.SaveUserAsync(item);
            var result2 = await App.Database.DeleteUserAsync(item);
            if (result == 1)
            {
                await Navigation.PushAsync(new UsersModifyPage());
            }

        }

    }
}