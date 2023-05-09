using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpHelper.Model
{
    public class Customer
    {
        private int _custID;
        private string _firstName;
        private string _lastName;
        private bool _isDeveloper;

        public int CustID { get => _custID; set => _custID = value; }
        public string FirstName { get => _firstName; set => _firstName = value; }
        public string LastName { get => _lastName; set => _lastName = value; }
        public bool IsDeveloper { get => _isDeveloper; set => _isDeveloper = value; }
    }
}
