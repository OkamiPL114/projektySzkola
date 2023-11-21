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
    public partial class UczenPage : ContentPage
    {
        public UczenPage(Uczen uczen)
        {
            InitializeComponent();
            imieLabel.Text = uczen.Imie;
            nazwiskoLabel.Text = uczen.Nazwisko;
            klasaLabel.Text = $"{uczen.Klasa}";
            miastoLabel.Text = uczen.Miasto;
        }
    }
}