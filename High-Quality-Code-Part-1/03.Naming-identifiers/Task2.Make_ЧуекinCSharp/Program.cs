using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Make_ЧуекinCSharp
{
    class Hauptklasse
    {
        enum GenderType
        {
            Male,
            Female
        };

        class Person
        {
            public GenderType Gender { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }
        }

        public void CreatePerson(int magicNumber)
        {
            Person person = new Person();
            person.Age = magicNumber;

            if (magicNumber % 2 == 0)
            {
                person.Name = "Батката";
                person.Gender = GenderType.Male;
            }
            else
            {
                person.Name = "Мацето";
                person.Gender = GenderType.Female;
            }
        }
    }
}
