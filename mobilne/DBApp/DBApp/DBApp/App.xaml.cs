using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DBApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }

        public static string GetDbPath()
        {
            var myDocuments = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var dbName = "contacts.db";
            var DbPath = System.IO.Path.Combine(myDocuments, dbName);
            return DbPath;
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
