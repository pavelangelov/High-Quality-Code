namespace Task2.CreatePerson
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            var femaleAge = 29;
            var maleAge = 30;
            var female = CreatePerson(femaleAge);
            var male = CreatePerson(maleAge);

            Console.WriteLine(female.Introduce());
            Console.WriteLine(male.Introduce());
        }

        public static Person CreatePerson(int magicNumber)
        {
            Person person = new Person();
            person.Age = magicNumber;

            if (person.Age % 2 == 0)
            {
                person.Name = "Big Boy";
                person.Gender = GenderType.Male;
            }
            else
            {
                person.Name = "Hot Chick";
                person.Gender = GenderType.Female;
            }

            return person;
        }
    }
}
