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
            Person person1 = new Person("John Snow", "123 Cold Rd Winterfell, The North, Westeros");
            Person person2 = new Student("Hermione Granger", "456 Somewhere in England", "Magical studies", 4, 30000.00);
            Person person3 = new Staff("Severus Snape", "The Dungeons", "Hogwarts", 30000.00);

            Console.WriteLine(person1.ToString());
            Console.WriteLine(person2.ToString());
            Console.WriteLine(person3.ToString());
            Console.ReadLine();
        }
    }
}
