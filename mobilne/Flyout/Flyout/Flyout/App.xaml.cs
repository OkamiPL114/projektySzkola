using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Flyout
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new SidePanelPage();
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
