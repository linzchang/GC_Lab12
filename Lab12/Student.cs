using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class Student : Person, IComparable<Student>
    {
        #region Data Members
        private string _program;
        private int _year;
        private double _fee;
        #endregion

        #region Properties
        public string Program
        {
            set
            {
                _program = value;
            }
            get
            {
                return _program;
            }
        }

        public int Year
        {
            set
            {
                _year = value;
            }
            get
            {
                return _year;
            }
        }

        public double Fee
        {
            set
            {
                _fee = value;
            }
            get
            {
                return _fee;
            }
        }
        #endregion

        #region Constructor
        public Student(string firstName, string lastName, string address, string program, int year, double fee) : base(firstName, lastName, address)
        {
            _program = program;
            _year = year;
            _fee = fee;
        }

        public Student()
        {
            _program = "General Studies";
            _year = 1;
            _fee = 0;
        }
        #endregion

        #region Methods
        public int CompareTo(Student otherStudent)
        {

            if (LastName == otherStudent.LastName)
            {
                return FirstName.CompareTo(otherStudent.FirstName);
            }
            return LastName.CompareTo(otherStudent.LastName);
        }

        public override string ToString()
        {
            return $"Name: {FirstName} {LastName} \nAddress: {Address}\nProgram: {Program} \nYear: {Year} \nFee: {Fee}\n";

        }
        #endregion
    }
}
