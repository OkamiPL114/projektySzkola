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

namespace examTask1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string password = "";
        string smallLetters = "abcdefghijklmopqrstuvwxyz";
        string bigLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        string numbers = "0123456789";
        string special = "!@#$%^&*()_+-=";
        Random random = new Random();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void generatePassButton_Click(object sender, RoutedEventArgs e)
        {
            password = "";
            bool doBigLetters = (bool)bigLettersCheckBox.IsChecked;
            bool doNumbers = (bool)numbersCheckBox.IsChecked;
            bool doSpecial = (bool)specialCheckBox.IsChecked;
            int numOfLetters = int.Parse(numOfLettersTextBox.Text);            
            for(int i = 0; i < numOfLetters; i++)
            {
                if (doBigLetters)
                {
                    password += $"{bigLetters[random.Next(0,25)]}";
                    doBigLetters = false;
                } else if (doNumbers)
                {
                    password += $"{numbers[random.Next(0,10)]}";
                    doNumbers = false;
                } else if (doSpecial)
                {
                    password += $"{special[random.Next(0,14)]}";
                    doSpecial = false;
                } else
                {
                    password += $"{smallLetters[random.Next(0,25)]}";
                }
            }
            MessageBox.Show(password);
        }

        private void confirmButton_Click(object sender, RoutedEventArgs e)
        {
            string position = "";
            switch (positionComboBox.SelectedIndex)
            {
                case 0: position = "Kierownik";break;
                case 1: position = "Starszy programista";break;
                case 2: position = "Młodszy programista";break;
                case 3: position = "Tester";break;
            }
            MessageBox.Show($"Dane pracownika: {nameTextBox.Text} {surnameTextBox.Text}, {position}, Hasło: {password}");
        }
    }
}
