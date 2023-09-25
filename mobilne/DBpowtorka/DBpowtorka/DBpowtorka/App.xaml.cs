using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DBpowtorka
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }
        public static string GetDBPath()
        {
            var personalPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var dbName = "employees.db";
            var dbPath = System.IO.Path.Combine(personalPath, dbName);

            return dbPath;
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
