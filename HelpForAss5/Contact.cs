using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpForAss5
{
    public class Contact
    {
        // public properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string ContactNumber { get; set; }
    
        // constructor
        public Contact(string first_name = "", string last_name = "", string email_address = "", string contact_number = "")
        {
            FirstName = first_name;
            LastName = last_name;
            EmailAddress = email_address;
            ContactNumber = contact_number;
        }
    }
}
