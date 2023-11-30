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

namespace ocenyUcznia
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Mark> marks = new List<Mark>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void addMarkButton_Click(object sender, RoutedEventArgs e)
        {
            addMark();

            calcArytAverage();

            calcWeigAverage();

            findMedian();
        }
        public void addMark()
        {
            int mark = int.Parse(markTextBox.Text.Trim());
            int weight = int.Parse(weightTextBox.Text.Trim());
            marks.Add(new Mark() { mark = mark, weight = weight });

            if (marks.Count == 1)
            {
                marksLabel.Content += $"{mark}";
            }
            else
            {
                marksLabel.Content += $", {mark}";
            }
            marksLabel.Visibility = Visibility.Visible;
            markTextBox.Text = "";
            weightTextBox.Text = "";
        }
        public void calcArytAverage()
        {
            double average = 0;
            for (int i = 0; i < marks.Count; i++)
            {
                average += marks[i].mark;
            }
            average = average / marks.Count;
            average = Math.Round(average, 2);
            averageArytLabel.Content = $"Średnia arytmetyczna ocen: {average}";
            averageArytLabel.Visibility = Visibility.Visible;
        }
        public void calcWeigAverage()
        {
            bubbleSort();
            double average = 0;
            int devider = 0;
            for(int i = 0; i < marks.Count; i++)
            {
                average += marks[i].mark * marks[i].weight;
                devider += marks[i].weight;
            }
            average /= devider;
            average = Math.Round(average, 2);
            averageWeigLabel.Content = $"Średnia ważona ocen: {average}";
            averageWeigLabel.Visibility = Visibility.Visible;
        }
        public void findMedian()
        {
            double median = 0;
            if(marks.Count % 2 == 0)
            {
                double first = marks[(marks.Count / 2) - 1].mark;
                double second = marks[marks.Count / 2].mark;
                median = (first + second) / 2;
            }
            else
            {
                if(marks.Count == 1)
                {
                    median = marks[0].mark;
                }
                else
                {
                    median = marks[(marks.Count / 2)].mark;
                }
            }
            medianLabel.Content = $"Mediana ocen: {median}";
            medianLabel.Visibility = Visibility.Visible;
        }
        public void bubbleSort()
        {
            for(int i = 0; i < marks.Count; i++)
            {
                for(int j = 0; j < marks.Count; j++)
                {
                    if(marks[i].mark < marks[j].mark)
                    {
                        (marks[i], marks[j]) = (marks[j], marks[i]);
                    }
                }
            }
        }
    }
}
