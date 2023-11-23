using System.Threading.Channels;

namespace ocenySzkolne
{
    internal class Program
    {
        static void Main()
        {
            Student Andrzej = new Student("Andrzej Barzyk");
            Student Anna = new Student("Anna Gwelowska");
            Student Wiktor = new Student("Wiktor Gajda");
            Student Marysia = new Student("Marysia Wieczysta");

            Andrzej.AddGrade(4);
            Andrzej.AddGrade(1);
            Andrzej.AddGrade(4);
            Andrzej.AddGrade(3);
            Andrzej.AddGrade(5);
            Andrzej.AddGrade(5);

            Console.WriteLine(Andrzej.Grades[0]);
            Console.WriteLine(Andrzej.Grades[1]);
            Console.WriteLine(Andrzej.Grades[2]);
            Console.WriteLine(Andrzej.Grades[3]);
            Console.WriteLine(Andrzej.Grades[4]);
            Console.WriteLine(Andrzej.Grades[5]);

            int searched = 3;
            if (Andrzej.BinarySearchGrade(searched))
            {
                Console.WriteLine($"Jest ocena {searched} w dzienniku");
            }
            else
            {
                Console.WriteLine($"Nie ma oceny {searched} w dzienniku");
            }
            searched = 6;
            if (Andrzej.BinarySearchGrade(searched))
            {
                Console.WriteLine($"Jest ocena {searched} w dzienniku");
            }
            else
            {
                Console.WriteLine($"Nie ma oceny {searched} w dzienniku");
            }
        }
    }
}