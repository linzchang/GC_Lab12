using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class Student : Person
    {
        #region Properties
        protected string _program { get; set; }
        protected int _year { get; set; }
        protected double _fee { get; set; }
        #endregion

        #region Constructor
        public Student(string name, string address, string program, int year, double fee) : base(name, address)
        {
            _program = program;
            _year = year;
            _fee = fee;
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"Name: {_name} \nAddress: {_address} \nProgram: {_program} \nYear: {_year} \nFee: {_fee}";
        }
        #endregion
    }
}
