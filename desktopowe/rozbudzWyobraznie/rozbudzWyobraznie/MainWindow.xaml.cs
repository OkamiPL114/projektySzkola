using System.IO;
using System.Windows;

namespace rozbudzWyobraznie
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

        private void saveNote_Click(object sender, RoutedEventArgs e)
        {
            string fileName = "text.txt";
            var path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments);
            var notesPath = Path.Combine(path, fileName);
            string text = saveNoteTextBox.Text;
            File.AppendAllText(notesPath, text);
        }

        private void readNote_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
