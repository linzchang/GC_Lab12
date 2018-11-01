using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class Person
    {
        #region Data Members
        private string _firstName;
        private string _lastName;
        private string _address;
        #endregion

        #region Properties
        public string FirstName
        {
            set
            {
                _firstName = value;
            }
            get
            {
                return _firstName;
            }
        }

        public string LastName
        {
            set
            {
                _lastName = value;
            }
            get
            {
                return _lastName;
            }
        }

        public string Address
        {
            set
            {
                _address = value;
            }
            get
            {
                return _address;
            }
        }
        #endregion

        #region Constructor
        public Person(string firstName, string lastName, string address)
        {
            _firstName = firstName;
            _lastName = lastName;
            _address = address;
        }

        public Person()
        {
            _firstName = "Your";
            _lastName = "Mom";
            _address = "123 Main St";
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"Name: {FirstName} {LastName} \nAddress: {Address}\n";
        }
        #endregion
    }
}
