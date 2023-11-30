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
        List<Mark> sortedMarks = new List<Mark>();
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
        }
        public void calcArytAverage()
        {
            int average = 0;
            for (int i = 0; i < marks.Count; i++)
            {
                average += marks[i].mark;
            }
            average = average / marks.Count;
            averageArytLabel.Content = $"Średnia arytmetyczna ocen: {average}";
            averageArytLabel.Visibility = Visibility.Visible;
        }
        public void calcWeigAverage()
        {
            int average = 0;
            int devider = 0;
            for(int i = 0; i < marks.Count; i++)
            {
                average += marks[i].mark;
                devider += marks[i].weight;
            }
            average = average / devider;
            averageWeigLabel.Content = $"Średnia ważona ocen: {average}";
            averageWeigLabel.Visibility = Visibility.Visible;
        }
        public void findMedian()
        {

        }
    }
}
