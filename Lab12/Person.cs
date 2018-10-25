using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class Person
    {
        #region Properties
        protected string _name { get; set; }
        protected string _address { get; set; }
        #endregion

        #region Constructor
        public Person(string name, string address)
        {
            _name = name;
            _address = address;
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"Name: {_name} \nAddress: {_address}";
        }
        #endregion
    }
}
