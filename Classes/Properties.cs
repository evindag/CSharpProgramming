using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    public class Properties
    {
        //fields
        public int Id { get; set; }
        public string LastName { get; set; }
        //encapsulation
        private string _firstName;
        public string FirstName
        {
            get { return "Mrs."+_firstName; }
            set { _firstName = value; }
        }

        


    }
}
