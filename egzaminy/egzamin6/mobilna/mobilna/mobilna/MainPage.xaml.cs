using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace mobilna
{
    public partial class MainPage : ContentPage
    {
        const int N = 10;
        int[] arr = new int[N];
        ObservableCollection<string> steps = new ObservableCollection<string>();
        Random random = new Random();
        public MainPage()
        {
            InitializeComponent();
        }

        private void createButton_Clicked(object sender, EventArgs e)
        {
            sortedLabel.Text = "";
            stepsListView.ItemsSource = null;
            steps.Clear();

            for (int i = 0; i < 10; i++)
            {
                arr[i] = random.Next(1, 101);
            }
            arrayLabel.Text = $"{arr[0]}";
            for(int i = 1; i < 10; i++)
            {
                arrayLabel.Text += $", {arr[i]}";
            }
            sortButton.IsEnabled = true;
        }

        private void sortButton_Clicked(object sender, EventArgs e)
        {
            for(int i = 0; i < 10; i++)
            {
                for(int j = 0; j < 10; j++)
                {
                    if(arr[i] < arr[j])
                    {
                        (arr[i], arr[j]) = (arr[j], arr[i]);
                        string step = $"{arr[0]}";
                        for(int k = 1; k < 10; k++)
                        {
                            step += $", {arr[k]}";
                        }
                        steps.Add(step);
                    }
                }
            }
            sortedLabel.Text = $"{arr[0]}";
            for (int i = 1; i < 10; i++)
            {
                sortedLabel.Text += $", {arr[i]}";
            }
            stepsListView.ItemsSource = steps;
        }
    }
}
