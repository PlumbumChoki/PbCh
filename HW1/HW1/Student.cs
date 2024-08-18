using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }        
        public DateTime BD { get; set; }
        public int Age { get { return DateTime.Now.Year - BD.Year; } }

        public Student(string firstName, string lastName, DateTime bd)
        {
            FirstName = firstName;
            LastName = lastName;
            BD = bd;
        }

        public override string ToString()//перегрузка класса object - базовый класс для всех классов
        {
            return $"{FirstName,-20} {LastName,-20} {{BD.ToShortDateString(),-20}} {{Age,-5";
        }


         
    }
}
