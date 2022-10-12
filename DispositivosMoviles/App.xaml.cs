using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using DispositivosMoviles.Data;
using System.IO;

namespace DispositivosMoviles
{
    public partial class App : Application
    {
        static DatabaseQueryDrago database;
        public static DatabaseQueryDrago Database
        {
            get
            {

                if (database == null)
                {
                    database = new DatabaseQueryDrago(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "ISC.db3"));
                }
                return database;
            }

        }
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage()) { BarBackgroundColor = Color.FromHex("#9ccc04") };
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
