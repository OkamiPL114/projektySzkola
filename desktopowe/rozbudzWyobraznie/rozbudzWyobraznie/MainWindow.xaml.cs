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
        private string NewNoteNumber()
        {
            string fileName = "number.txt";
            var path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments);
            var numberPath = Path.Combine(path, fileName);
            if (!File.Exists(numberPath))
            {
                File.WriteAllText(numberPath, "1");
                return "1";
            }
            else
            {
                string noteNum = File.ReadAllText(numberPath);
                int noteNumInt = int.Parse(noteNum) + 1;
                File.WriteAllText(numberPath, noteNumInt.ToString());
                return noteNumInt.ToString();
            }
        }
        private string GetNoteNumber()
        {
            string fileName = "number.txt";
            var path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments);
            var numberPath = Path.Combine(path, fileName);

            string noteNum = File.ReadAllText(numberPath);
            return noteNum.ToString();
        }
        private void saveNote_Click(object sender, RoutedEventArgs e)
        {
            string fileName = "notes.txt";
            var path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments);
            var notesPath = Path.Combine(path, fileName);
            string text = saveNoteTextBox.Text;
            File.AppendAllText(notesPath, $"{NewNoteNumber()}.{text}\n");
        }

        private void readNote_Click(object sender, RoutedEventArgs e)
        {
            string noteNum = GetNoteNumber();

        }
    }
}
