using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class ArchivedStudent : Student, IComparable<ArchivedStudent>
    {
        #region Data Members
        private int _finalScore;
        #endregion

        #region Properties
        public int FinalScore
        {
            set
            {
                _finalScore = value;
            }
            get
            {
                return _finalScore;
            }
        }
        #endregion

        #region Constructor
        public ArchivedStudent(string firstName, string lastName, string address, string program, int year, double fee, int finalScore) : base(firstName, lastName, address, program, year, fee)
        {
            _finalScore = finalScore;
        }

        public ArchivedStudent()
        {
            _finalScore = 0;
        }
        #endregion

        #region Methods
        public int CompareTo(ArchivedStudent otherStudent)
        {

            if (LastName == otherStudent.LastName)
            {
                return FirstName.CompareTo(otherStudent.FirstName);
            }
            return LastName.CompareTo(otherStudent.LastName);
        }

        public override string ToString()
        {
            return $"Name: {FirstName} {LastName} \nAddress: {Address}\nProgram: {Program} \nYear: {Year} \nFee: {Fee} \nFinal Score: {FinalScore}\n";

        }
        #endregion
    }
}
