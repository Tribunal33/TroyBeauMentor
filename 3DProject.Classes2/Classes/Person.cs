using _3DProject.Interfaces;

namespace _3DProject.Classes2
{
    internal class Person : IPerson
    {
        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string FirstName { get;set; }
        public string LastName { get; set; }
    }
}