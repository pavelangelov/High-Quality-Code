namespace Task2.CreatePerson
{
    public class Person
    {
        public GenderType Gender { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public string Introduce()
        {
            return $"Name: {this.Name}, Sex: {this.Gender}, Age: {this.Age}";
        }
    }
}
