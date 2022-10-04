using System;
using System.Net.Mail;
using System.Text;
using System.Windows.Input;
using System.Collections.Generic;
using Xamarin.Forms;
using CommunityToolkit.Mvvm.Input;

namespace DispositivosMoviles.ViewModels
{
    internal class ForgotPasswordViewModel:BaseViewModel
    {
        #region Atributes
        private string email;
        private string password;

        public bool IsRuning;
        public bool IsVisible;
        public bool IsEnable;
        #endregion

        #region Porperties

        public string EmailTxt
        {
            get { return this.email; }
            set { SetValue(ref this.email, value); }
        }

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

        public bool IsEnableTxt
        {
            get { return this.IsEnable; }
            set { SetValue(ref this.IsEnable, value); }
        }

        #endregion



        #region Commands
        public ICommand EnviarCorreoCommand
        {
            get { return new RelayCommand(EnviarCorreo);  }
            set { }
        }


        #endregion

        #region Methods
        private async void EnviarCorreo()
        {
            //var e = App.Database.GetUserPassword(email).Result();

            //string passwordDelUsuario = e.Password;
            string passwordDelUsuario = "Contraseña";
            try
            {
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                MailMessage message = new MailMessage();
                message.From = new MailAddress("18030536@itesa.edu.mx", "Sistema de Base de Datos");
                message.To.Add(email);
                message.To.Add("18030536@itesa.edu.mx");
                message.Subject = "Aplicacion de Drago";
                message.Body = "Prueba 1: " + email + " contraseña: " + passwordDelUsuario;
                client.EnableSsl = true;
                client.Credentials = new System.Net.NetworkCredential("18030536@itesa.edu.mx", "18030536SDDR");
                client.Send(message);
                await Application.Current.MainPage.DisplayAlert("Asistente de Email", "Se a enviado el password de el cliente","Aceptar");
                await Application.Current.MainPage.Navigation.PushAsync(new LoginPage());
            }
            catch
            {
                return;
            }
        }
        #endregion

        #region Constructor
        public ForgotPasswordViewModel()
        {
            this.IsEnable = true;
        }
        #endregion


    }
}
