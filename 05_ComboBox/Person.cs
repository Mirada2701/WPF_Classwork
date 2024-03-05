using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ComboBox
{
    class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Birthday { get; set; }
        public string FullInfoAboutPerson => Name + " " + Surname;
        public override string ToString()
        {
            return Name + " " + Surname + " " + Birthday;
        }
    }
}
