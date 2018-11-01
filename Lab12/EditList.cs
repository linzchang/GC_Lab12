using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class EditList
    {
        public static Student AddStudent(Student student)
        {
            student.FirstName = Validation.GetString("Enter first name: ");
            student.LastName = Validation.GetString("Enter last name: ");
            student.Address = Validation.GetResponse("Enter address: ");
            student.Program = Validation.GetString("Enter program: ");
            student.Year = Validation.GetInt("Enter year: ");
            student.Fee = Validation.GetDouble("Enter fee: ");
            return student;
        }

        public static Student AddStudent(ArchivedStudent archivedStudent)
        {
            
            string firstName = Validation.GetString("Enter first name: ");
            string lastName = Validation.GetString("Enter last name: ");
            string address = Validation.GetResponse("Enter address: ");
            string program = Validation.GetString("Enter program: ");
            int year = Validation.GetInt("Enter year: ");
            double fee = Validation.GetDouble("Enter fee: ");
            int finalScore = Validation.GetScore("Enter final score: ");
            Student student = new ArchivedStudent(firstName, lastName, address, program, year, fee, finalScore);
            return student;
        }
    }
}
