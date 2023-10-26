using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Customer
    {
        //field bir classın içinde  özellikleri tutmak için kullanılanılır.
        //public string FirstName; // bu şekilde de yazılabilir.

        public int Id { get; set; }

        // ---  ENCAPSULATION ---

        private string _firstName;
        public string FirstName
        {
            get { return "Mrs." + _firstName; }

            set { _firstName = value; } // value set etmek istediğimiz değere karşılık gelir

        }

        public string LastName { get; set; }
        public string City { get; set; }

    }
}
