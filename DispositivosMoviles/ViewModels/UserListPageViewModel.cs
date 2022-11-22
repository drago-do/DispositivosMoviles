using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using CommunityToolkit.Mvvm.Input;
using DispositivosMoviles.Models;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
//using DispositivosMoviles.Views;
using System.IO;
using System.Threading.Tasks;
using DispositivosMoviles;
using DispositivosMoviles.Views;

namespace DispositivosMoviles.ViewModels
{
    internal class UserListPageViewModel
    {
        #region Attributes

        #endregion

        #region Properties

        #endregion

        #region Commands
        //Comando para editar y eliminar un usuario
        public ICommand EditarCommand { get { return new RelayCommand(Editar); } }
        public ICommand EliminarCommand { get { return new RelayCommand(Eliminar); } }



        #endregion

        #region Methods
        //Metodo para editar un usuario, se llama cuando se hace click en el boton editar
        private async void Editar()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new UsersModifyPage());
        }

        //Metodo para eliminar un usuario, se llama cuando se hace click en el boton eliminar
        private async void Eliminar()
        {
            await Application.Current.MainPage.DisplayAlert("Eliminar", "¿Desea eliminar el usuario?", "Si", "No");
            //Si se presiona el boton si, se elimina el usuario
            //await App.Database.DeleteUserAsync(user);
            //ListViewUser.ItemsSource = await App.Database.GetTodoModel();
        }

        #endregion

        #region Constructor

        #endregion

    }
}
