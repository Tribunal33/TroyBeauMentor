using _3DProject.Interfaces;

namespace _3DProject.Classes
{
    public class StringRef : IThing<string>
    {
        public StringRef(string key, string name, string value)
        {
            Key = key;
            Name = name;
            Value = value;
        }

        public string Key { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
    }
}
