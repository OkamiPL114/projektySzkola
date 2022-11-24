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
        private string IncreaseNoteNumber()
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
        private void DecreaseNoteNumber()
        {
            string fileName = "number.txt";
            var path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments);
            var numberPath = Path.Combine(path, fileName);
            string noteNum = File.ReadAllText(numberPath);
            int noteNumInt = int.Parse(noteNum) - 1;
            File.WriteAllText(numberPath, noteNumInt.ToString());
        }
        private string GetNoteNumber()
        {
            string fileName = "number.txt";
            var path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments);
            var numberPath = Path.Combine(path, fileName);

            if (File.Exists(numberPath))
            {
                string noteNum = File.ReadAllText(numberPath);
                return noteNum.ToString();
            }
            return "1";
        }
        private void saveNote_Click(object sender, RoutedEventArgs e)
        {
            if(saveNoteTextBox.Text != "")
            {
                string fileName = "notes.txt";
                var path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments);
                var notesPath = Path.Combine(path, fileName); //notatki zapisują się w Dokumentach
                string text = saveNoteTextBox.Text;
                File.AppendAllText(notesPath, $"{IncreaseNoteNumber()}.{text}\n");
                saveNoteTextBox.Text = "";
                MessageBox.Show("Dodano notatkę");
                return;
            }
            MessageBox.Show("Nie można dodać pustej notatki");
        }

        private void readNote_Click(object sender, RoutedEventArgs e)
        {
            string fileName = "notes.txt";
            var path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments);
            var notesPath = Path.Combine(path, fileName);
            if(File.Exists(notesPath))
            {
                string noteNum = GetNoteNumber();
                using (var reader = new StreamReader(notesPath))
                {
                    for (int i = 0; i < int.Parse(noteNum); i++)
                    {
                        string line = reader.ReadLine();
                        if (line[0].ToString() == noteNum)
                        {
                            readNoteTextBox.Text = line;
                        }
                    }
                }
                return;
            }
            MessageBox.Show("Nie zapisano żadnych notatek");
        }
        private void deleteNote_Click(object sender, RoutedEventArgs e)
        {
            string fileName = "notes.txt";
            var path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments);
            var notesPath = Path.Combine(path, fileName);
            string noteNum = GetNoteNumber();
            if (File.Exists(notesPath))
            {
                fileName = "temp.txt";
                var tempPath = Path.Combine(path, fileName);
                using (var reader = new StreamReader(notesPath))
                {
                    for (int i = 0; i < int.Parse(noteNum); i++)
                    {
                        string line = reader.ReadLine();
                        if (line[0].ToString() != noteNum)
                        {
                            File.AppendAllText(tempPath, line);
                        }
                    }
                    DecreaseNoteNumber();
                }
                noteNum = GetNoteNumber();
                using (var reader2 = new StreamReader(tempPath))
                {
                    for (int i = 0; i < int.Parse(noteNum); i++)
                    {
                        string line = reader2.ReadLine();
                        File.WriteAllText(notesPath, line);
                    }
                    File.AppendAllText(notesPath, "\n");
                }
                MessageBox.Show("Usunięto notatkę");
                readNoteTextBox.Text = "";
                File.Delete(tempPath);
                return;
            }
            MessageBox.Show("Nie zapisano żadnych notatek");
        }
    }
}
