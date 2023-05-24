using System;
using System.Collections.Generic;
using System.Text;
using SQLite; //!!!!!!!!!!!!

namespace DBApp.Models
{
    public class Contact
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
