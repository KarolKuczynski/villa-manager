using System;
using System.Collections.Generic;
using System.Text;

namespace model
{
    public class Guest : Entity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}
