namespace notesExam
{
    class Notatka
    {
        private static int notesAmount = 0;
        private int noteId;
        protected string noteTitle;
        protected string noteContent;
        public Notatka(string title, string content)
        {
            notesAmount++;
            this.noteId = notesAmount;
            this.noteTitle = title;
            this.noteContent = content;
        }
        public void displayNoteText()
        {
            Console.WriteLine($"Tytuł notatki: {noteTitle}");
            Console.WriteLine();
            Console.WriteLine($"Treść notatki: {noteContent}");
            Console.WriteLine();
        }
        public void displayNoteInfo()
        {
            Console.WriteLine($"Ilość notatek: {notesAmount}; ID notatki: {noteId}; tytuł notatki: {noteTitle}; treść notatki: {noteContent}");
            Console.WriteLine();
            Console.WriteLine();
        }
    }
    internal class Program
    {
        static void Main()
        {
            Notatka notatka1 = new Notatka("Mój PESEL", "04314013479");
            Notatka notatka2 = new Notatka("Filmy na wieczór filmowy", "Alfa, Transformers 3, Piraci z Karaibów: Zemsta Salazara, Battleship:Bitwa o Ziemię");

            notatka1.displayNoteText();
            notatka1.displayNoteInfo();

            notatka2.displayNoteText();
            notatka2.displayNoteInfo();
        }
    }
}