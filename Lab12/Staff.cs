using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class Staff : Person
    {
        #region Properties
        protected string _school { get; set; }
        protected double _pay { get; set; }
        #endregion

        #region Constructor
        public Staff(string name, string address, string school, double pay) : base(name, address)
        {
            _school = school;
            _pay = pay;
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"Name: {_name} \nAddress: {_address} \nSchool: {_school} \nPay: {_pay}";
        }
        #endregion
    }
}
