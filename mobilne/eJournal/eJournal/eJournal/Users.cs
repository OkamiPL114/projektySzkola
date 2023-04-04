using System;
using System.Collections.Generic;
using System.Text;

namespace eJournal
{
    class Users
    {
        public static List<User> accounts = new List<User>()
        {
            new User(){ Email = "nowak@test.pl", Password = "1234"},
        };
    }
}
