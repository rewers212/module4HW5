using System;
using System.Collections.Generic;

namespace Module4HW5
{
    public class Client
    {
        public int ClientId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Country { get; set; }
        public DateTime DateOfBirth { get; set; }
        public virtual List<Project> Projects { get; set; } = new List<Project>();
    }
}
