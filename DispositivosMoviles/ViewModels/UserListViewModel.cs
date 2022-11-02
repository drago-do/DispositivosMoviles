using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DispositivosMoviles.Data;

namespace DispositivosMoviles.ViewModels
{
    internal class UserListViewModel : BaseViewModel
    {
        #region Attibutes
        public object listViewSource;
        #endregion

        #region Propierties
        public object ListViewSource
        {
            get { return this.listViewSource; }
            set { SetValue(ref this.listViewSource,value); }
        }
        #endregion

        #region Commands

        #endregion

        #region Methods
        public async Task LoadData()
        {
            this.ListViewSource = await App.Database.GetTodoModel();
        }

        #endregion

        #region Constructor
        public UserListViewModel()
        {
            LoadData();
        }
        #endregion
    }
}
