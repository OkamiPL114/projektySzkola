using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace DBpowtorka
{
    public class Employee
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public float Salary{ get; set; }
    }
}
