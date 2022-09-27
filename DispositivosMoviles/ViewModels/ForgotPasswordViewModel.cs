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
        private void EnviarCorreo()
        {
            //throw new NotImplementedException();
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
