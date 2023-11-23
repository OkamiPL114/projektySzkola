using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ocenySzkolne
{
    internal class Student
    {
        public string Name { get; set; }
        public List<int> Grades;
        public Student(string name) 
        {
            this.Name = name;
            Grades = new List<int>();
        }
        public void AddGrade(int grade)
        {
            Grades.Add(grade);
            for(int i = 0; i < Grades.Count; i++)
            {
                for(int j = 0; j < Grades.Count - 1; j++)
                {
                    if (Grades[i] < Grades[j])
                    {
                        (Grades[i], Grades[j]) = (Grades[j], Grades[i]);
                    }
                }
            }
        }
        public bool BinarySearchGrade(int searched)
        {
            int left = 0;
            int right = Grades[Grades.Count - 1];
            while(left <= right)
            {
                int mid = (left + right) / 2;
                if(Grades[mid] == searched)
                {
                    return true;
                }
                else if(Grades[mid] > searched)
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }
            return false;
        }
    }
}
