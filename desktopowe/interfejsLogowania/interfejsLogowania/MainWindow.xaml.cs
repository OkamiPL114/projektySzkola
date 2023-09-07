using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace interfejsLogowania
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        const string correctPass = "tajnehaslo";
        List<string> wrongPasswords = new List<string>();
        public MainWindow()
        {
            InitializeComponent();
            historyListBox.ItemsSource = wrongPasswords;
        }

        private void loginButton_Click(object sender, RoutedEventArgs e)
        {
            string pass = passPasswordBox.Password;
            if(pass != correctPass)
            {
                wrongPasswords.Add(pass);
                historyListBox.ItemsSource = null;
                historyListBox.ItemsSource = wrongPasswords;
                return;
            }
            string name = nameTextBox.Text;
            string surname = surnameTextBox.Text;
            string position = ((ComboBoxItem)positionComboBox.SelectedItem)?.Content.ToString();
            MessageBox.Show($"Poprawnie zalogowano!\nImię:{name}\nNazwisko:{surname}\nStanowisko:{position}", "Sukces");
        }
    }
}
