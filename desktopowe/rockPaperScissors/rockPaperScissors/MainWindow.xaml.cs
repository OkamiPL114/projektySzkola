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

namespace rockPaperScissors
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int selected;
        Random random = new Random();
        public MainWindow()
        {
            InitializeComponent();
        }
        private void rockImage_MouseDown(object sender, MouseButtonEventArgs e)
        {
            selected = 0;
            selectedLabel.Content = "Wybrano: kamień";
        }

        private void paperImage_MouseDown(object sender, MouseButtonEventArgs e)
        {
            selected = 1;
            selectedLabel.Content = "Wybrano: papier";
        }

        private void scissorsImage_MouseDown(object sender, MouseButtonEventArgs e)
        {
            selected = 2;
            selectedLabel.Content = "Wybrano: nożyce";
        }
        private void moveButton_Click(object sender, RoutedEventArgs e)
        {
            switch (random.Next(0, 3)){
                case 0:
                    {
                        switch (selected) {
                            case 0: resultLabel.Content = "Komputer wylosował kamień. Remis"; break;
                            case 1: resultLabel.Content = "Komputer wylosował kamień. Wygrywasz"; break;
                            case 2: resultLabel.Content = "Komputer wylosował kamień. Przegrywasz"; break;
                        }
                    };break;
                case 1:
                    {
                        switch (selected)
                        {
                            case 0: resultLabel.Content = "Komputer wylosował Papier. Przegrywasz"; break;
                            case 1: resultLabel.Content = "Komputer wylosował kamień. Remis"; break;
                            case 2: resultLabel.Content = "Komputer wylosował kamień. Wygrywasz"; break;
                        }
                    };break;
                case 2:
                    {
                        switch (selected)
                        {
                            case 0: resultLabel.Content = "Komputer wylosował nożyce. Wygrywasz"; break;
                            case 1: resultLabel.Content = "Komputer wylosował nożyce. Przegrywasz"; break;
                            case 2: resultLabel.Content = "Komputer wylosował nożyce. Remis"; break;
                        }
                    };break;
            }
        }
    }
}
