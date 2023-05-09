using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Flyout
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SidePanelPageFlyout : ContentPage
    {
        public ListView ListView;

        public SidePanelPageFlyout()
        {
            InitializeComponent();

            BindingContext = new SidePanelPageFlyoutViewModel();
            ListView = MenuItemsListView;
        }

        private class SidePanelPageFlyoutViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<SidePanelPageFlyoutMenuItem> MenuItems { get; set; }

            public SidePanelPageFlyoutViewModel()
            {
                MenuItems = new ObservableCollection<SidePanelPageFlyoutMenuItem>(new[]
                {
                    new SidePanelPageFlyoutMenuItem { Id = 0, Title = "Strona główna", TargetType = typeof(MainPage), Icon = "home.png" },
                    new SidePanelPageFlyoutMenuItem { Id = 1, Title = "Galeria", TargetType = typeof(GalleryPage), Icon = "gallery.png" },
                    new SidePanelPageFlyoutMenuItem { Id = 2, Title = "O mnie", TargetType = typeof(AboutPage), Icon = "about.png" },
                });
            }

            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}