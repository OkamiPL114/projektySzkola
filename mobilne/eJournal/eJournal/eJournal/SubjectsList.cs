using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;

namespace eJournal
{
    class SubjectsList
    {
        public static ObservableCollection<Subject> subjects = new ObservableCollection<Subject>()
        {
            new Subject(){ Name = "Matematyka", Grades = new List<int>(){ 3, 5, 2, 0} },
            new Subject(){ Name = "J. polski", Grades = new List<int>(){ 1, 2, 4, 3} },
            new Subject(){ Name = "J. angielski", Grades = new List<int>(){ 4, 5, 3, 2} },
        };
    }
}
