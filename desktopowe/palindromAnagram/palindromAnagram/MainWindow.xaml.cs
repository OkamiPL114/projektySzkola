﻿using System;
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

namespace palindromAnagram
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void palindromButton_Click(object sender, RoutedEventArgs e)
        {
            // usunięcie znaków specjalnych + spacji z wyrazu
            string palCand = firstTextBox.Text;
            palCand = palCand.ToLower().Trim();
            string pal = "";
            for(int i = 0; i < palCand.Length; i++)
            {
                if (palCand[i] != ' ' && palCand[i] != ',' && palCand[i] != '.' && palCand[i] != '-' && palCand[i] != '_')
                {
                    pal += palCand[i];
                }
            }

            // faktyczne sprawdzenie czy wyraz jest palindromem
            int start = 0;
            int end = pal.Length - 1;
            for(int i = 0; i <= pal.Length / 2; i++)
            {
                if (pal[start] != pal[end])
                {
                    MessageBox.Show("Pierwsze słowo nie jest palindromem");
                    return;
                }
            }
            MessageBox.Show("Pierwsze słowo jest palindromem");
        }

        private void anagramButton_Click(object sender, RoutedEventArgs e)
        {
            string first = firstTextBox.Text;
            string second = secondTextBox.Text;
            if(first.Length != second.Length)
            {
                MessageBox.Show("Słowa nie są anagramami");
                return;
            }
            char[] arr1 = first.ToCharArray();
            char[] arr2 = second.ToCharArray();
            
            Array.Sort(arr1);
            Array.Sort(arr2);
            for(int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] != arr2[i])
                {
                    MessageBox.Show("Słowa nie są anagramami");
                    return;
                }
            }
            MessageBox.Show("Słowa są anagramami");
        }
    }
}
