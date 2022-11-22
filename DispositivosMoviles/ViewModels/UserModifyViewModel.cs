using CommunityToolkit.Mvvm.Input;
using DispositivosMoviles.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
//using DispositivosMoviles.Views;
using System.IO;
using System.Threading.Tasks;

namespace DispositivosMoviles.ViewModels
{
    internal class UserModifyViewModel : BaseViewModel
    {
        #region Attributes
        private string usuario;
        private string password;
        private string email;
        private string appaterno;
        private string apmaterno;
        private string edad;
        private string pais;
        private string apellidos;

        public bool IsRuning;
        public bool IsVisible;
        public bool IsEnabled;


        #endregion

        #region Properties
        public bool IsRuningTxt
        {
            get { return this.IsRuning; }
            set { SetValue(ref this.IsRuning, value); }
        }

        public bool IsVisibleTxt
        {
            get { return this.IsVisible; }
            set { SetValue(ref this.IsVisible, value); }
        }

        public bool IsEnabledTxt
        {
            get { return this.IsEnabled; }
            set { SetValue(ref this.IsEnabled, value); }
        }

        public string UsuarioTxt
        {
            get { return this.usuario; }
            set { SetValue(ref this.usuario, value); }
        }

        public string PasswordTxt
        {
            get { return this.password; }
            set { SetValue(ref this.password, value); }
        }

        public string EmailTxt
        {
            get { return this.email; }
            set { SetValue(ref this.email, value); }
        }

        public string ApPaternoTxt
        {
            get { return this.appaterno; }
            set { SetValue(ref this.appaterno, value); }
        }

        public string ApMaternoTxt
        {
            get { return this.apmaterno; }
            set { SetValue(ref this.apmaterno, value); }
        }

        public string EdadTxt
        {
            get { return this.edad; }
            set { SetValue(ref this.edad, value); }
        }

        public string PaisPicker
        {
            get { return this.pais; }
            set { SetValue(ref this.pais, value); }
        }

        public string ApellidosTxt
        {
            get { return $"{ApPaternoTxt} {ApMaternoTxt}"; }
            set { SetValue(ref this.apellidos, value); }
        }
        #endregion

        #region Commands
        
        public ICommand UpdateCommand
        {
            get
            {
                return new RelayCommand(UpdateMethod);
            }
        }


        #endregion

        #region Methods
        private async void UpdateMethod()
        {
            if (string.IsNullOrEmpty(this.UsuarioTxt))
            {
                await Application.Current.MainPage.DisplayAlert("Error en la matrix", "Te falta el nombre chavo", "Aceptar");
                return;
            }
            if (string.IsNullOrEmpty(this.PasswordTxt))
            {
                await Application.Current.MainPage.DisplayAlert("Error en la matrix", "Te falta la contraseña chavo", "Aceptar");
                return;
            }
            if (string.IsNullOrEmpty(this.EmailTxt))
            {
                await Application.Current.MainPage.DisplayAlert("Error en la matrix", "Te falta el correo chavo", "Aceptar");
                return;
            }
            if (string.IsNullOrEmpty(this.ApPaternoTxt))
            {
                await Application.Current.MainPage.DisplayAlert("Error en la matrix", "Te falta el Apellido de tu jefe chavo", "Aceptar");
                return;
            }
            if (string.IsNullOrEmpty(this.ApMaternoTxt))
            {
                await Application.Current.MainPage.DisplayAlert("Error en la matrix", "Te falta el Apellido de tu jefita chavo", "Aceptar");
                return;
            }

            if (string.IsNullOrEmpty(this.EdadTxt))
            {
                await Application.Current.MainPage.DisplayAlert("Error en la matrix", "Te falta el edad chavo", "Aceptar");
                return;
            }
            if (string.IsNullOrEmpty(this.PaisPicker))
            {
                await Application.Current.MainPage.DisplayAlert("Error en la matrix", "Te falta el Pais chavo", "Aceptar");
                return;
            }
            this.IsEnabled = true;
            this.IsRuning = true;
            this.IsVisible = true;

            await Task.Delay(1000);

            var user = new UserDrago
            {
                Usuario = UsuarioTxt.ToLower(),
                Password = PasswordTxt.ToLower(),
                Email = EmailTxt.ToLower(),
                ApPaterno = ApPaternoTxt.ToLower(),
                ApMaterno = ApMaternoTxt.ToLower(),
                Edad = EdadTxt.ToLower(),
                Pais = PaisPicker.ToLower(),
                Fecha_De_Creacion = DateTime.UtcNow
            };

            //Se guarda el registro
            await App.Database.SaveUserAsync(user);

            await Application.Current.MainPage.DisplayAlert("Ya estuvo", "Ya actualimamos hommie" + usuario.ToString(), "Yastas");
            this.IsRuning = false;
            this.IsVisibleTxt = false;
            this.IsEnabledTxt = true;
            await Application.Current.MainPage.Navigation.PushAsync(new LoginPage());
        }


        #endregion

        #region Constructor

        public UserModifyViewModel()
        {
            this.IsRuning = false;
            this.IsVisible = false;
            this.IsEnabled = true;
            this.IsEnabledTxt = true;
        }

        #endregion
    }
}
