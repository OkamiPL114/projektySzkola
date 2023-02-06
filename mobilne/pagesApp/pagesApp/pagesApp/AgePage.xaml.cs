using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace pagesApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AgePage : ContentPage
    {
        public AgePage(int age)
        {
            InitializeComponent();
            int currentYear = DateTime.Now.Year;
            int birthYear = currentYear - age;
            string message = $"Urodziłeś się w {birthYear} roku.";
            birthYearLabel.Text = message;
        }
    }
}