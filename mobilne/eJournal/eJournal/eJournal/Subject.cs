using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace eJournal
{
    class Subject
    {
        public string Name { get; set; }
        public List<int> Grades { get; set; }
        private string _GradesStr;
        public string GradesStr
        {
            get 
            {
                string temp = "";

                foreach (var item in Grades)
                {
                    temp += $"{item}, ";
                }
                temp = temp.Substring(0, temp.Length - 2);
                
                return temp;
            }
            set
            {
                _GradesStr = value;
            }
        }
    }
}
