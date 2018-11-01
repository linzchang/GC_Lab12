using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class Staff : Person
    {
        #region Data Members
        private string _school;
        private double _pay;
        #endregion

        #region Properties
        public string School
        {
            set
            {
                _school = value;
            }
            get
            {
                return _school;
            }
        }

        public double Pay
        {
            set
            {
                _pay = value;
            }
            get
            {
                return _pay;
            }
        }
        #endregion

        #region Constructor
        public Staff(string firstName, string lastName, string address, string school, double pay) : base(firstName, lastName, address)
        {
            _school = school;
            _pay = pay;
        }

        public Staff()
        {
            _school = "High School";
            _pay = 0;
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"Name: {FirstName} {LastName}\nAddress: {Address}\nSchool: {School} \nPay: {Pay}\n";
        }
        #endregion
    }
}
