using _3DProject.Interfaces;

namespace _3DProject.Classes2
{
    public class IntegerRef : IThing<int>
    {
        public IntegerRef(string key, string name, int value)
        {
            Key = key;
            Name = name;
            Value = value;
        }

        public string Key { get; set; }
        public string Name { get; set; }
        public int Value { get; set; }
    }
}
