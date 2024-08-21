using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_3._1
{
    public class Person
    {
        public string? FirstName { get; set; }
        public string? Surname { get; set; }
        public string? SecondName { get; set; }
        public string? Email { get; set; }

        public override string ToString()
        {
            return $"Имя: {FirstName} Фамилия: {Surname} Отчество: {SecondName} Email: {Email}";
        }
    }
}
