using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Ron", "Weasley", "456 Somewhere in England", "Magical studies", 4, 30000.00);
            Student student3 = new Student("Ginny", "Weasley", "456 Somewhere in Englad", "Magical studies", 1, 300.00);
            Student student5 = new Student("Elsa", "Icy", "Ice Mountain", "Freezing People", 12, 4500.00);
            Student student2 = new ArchivedStudent("Leeroy", "Jenkins", "123 Nowhere IronForge", "Paladin studies", 4, 30000.00, 5);
            Student student4 = new ArchivedStudent("Sandy", "Cheeks", "1 Glass Dome Bikini Bottom", "Kickin butt", 1, 50000.00, 90);
            Student student6 = new ArchivedStudent();

            List<Student> studentList = new List<Student> { student1, student2, student3, student4, student5, student6};
            Console.WriteLine("Welcome to the Student Database!");
            MainMenu(studentList);
        }

        public static void MainMenu(List<Student> studentList)
        {
            while (true)
            {
                string switchAnswer = Validation.GetResponse("Select 1 to View a list of students or 2 to Add a student to the list: ");
                switch (switchAnswer)
                {
                    case "1":
                        studentList.Sort();
                        Console.WriteLine(" ");
                        int count = 1;
                        foreach (Student student in studentList)
                        {
                            Console.WriteLine($"Student {count}: ");
                            Console.WriteLine(student.ToString());
                            count++;
                        }
                        break;
                    case "2":
                        AddStudent(studentList);
                        Console.WriteLine(" ");
                        break;
                    default:
                        Console.WriteLine("That is not a valid selection, try again.\n");
                        continue;
                }

                string endProgram = Validation.GetResponse("Would you like to continue to the main menu?  Press Y to continue: ");
                if (endProgram.ToUpper() != "Y")
                {
                    break;
                }
                Console.Clear();
            }
        }

        public static void AddStudent(List<Student> studentList)
        {
            string answer = Validation.GetResponse("\nSelect 1) to add a Current Student or 2) for an Archived Student: ");
            while (true)
            {
                if (answer == "1")
                {
                    Student student = new Student();
                    student = EditList.AddStudent(student);
                    studentList.Add(student);
                    break;
                }
                else if (answer == "2")
                {
                    ArchivedStudent archivedStudent = new ArchivedStudent();
                    Student student = new ArchivedStudent();
                    student = EditList.AddStudent(archivedStudent);
                    studentList.Add(student);
                    break;
                }
                else
                {
                    answer = Validation.GetResponse("Sorry, that's not valid.  Please enter 1 or 2. ");
                    continue;
                }
            }
        }

    }
}
