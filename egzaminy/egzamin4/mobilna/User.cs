using System;
using System.Collections.Generic;
using System.Text;

namespace mobilna
{
    internal class User
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Password { get; set; }
        public DateTime Birthday { get; set; }
        public bool StatuteAccepted { get; set; }
    }
}
