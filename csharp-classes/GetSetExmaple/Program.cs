using System;

namespace GetSetExample
{

    public class Person
    {
        private string _name;
        public string Name { get { return _name; } set { _name = value; } }
    }

    public class Pet
    {
        private string _name;
        public string Name { get; set; }
    }


    public class Program
    {
        public static void Main(string[] args)
        {
            Person person = new Person();
            person.Name = "Oskar";
            Console.WriteLine(person.Name);

            Pet pet = new Pet();
            pet.Name = "Hades";
            Console.WriteLine(pet.Name);
        }
    }
}
