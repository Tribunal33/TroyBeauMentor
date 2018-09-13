using _3DProject.Interfaces;

namespace _3DProject.Classes2
{
    public class PersonRef : IThing<IPerson>
    {
        public PersonRef(string key, string name, string firstName, string lastName)
        {
            Key = key;
            Name = name;
            Value = new Person(firstName, lastName);
        }

        public string Key { get; set; }
        public string Name { get; set; }
        public IPerson Value { get; set; }
    }
}
