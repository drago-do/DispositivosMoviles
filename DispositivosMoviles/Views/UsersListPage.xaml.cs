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

        //public UserWatchDetails()
        //{

        //}
    }
}