using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace mobilna
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UserPage : ContentPage
    {
        internal UserPage(User loggedUser)
        {
            InitializeComponent();
            firstLabel.Text = $"Witaj {loggedUser.Name} {loggedUser.Surname}";
            secondLabel.Text = $"Data urodzenia: {loggedUser.Birthday.ToShortDateString()}";
            thirdLabel.Text = loggedUser.StatuteAccepted ? "Zaakceptowano regulamin" : "Nie zaakceptowano regulaminu";
        }
    }
}