using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using DispositivosMoviles.ViewModels;

namespace DispositivosMoviles.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UsersModifyPage : ContentPage
    {
        public UsersModifyPage()
        {
            InitializeComponent();
            BindingContext = new UserModifyViewModel();
        }
    }
}