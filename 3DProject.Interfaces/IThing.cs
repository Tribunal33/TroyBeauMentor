namespace _3DProject.Interfaces
{
    public interface IThing<T>
    {
        string Key { get; set; }

        string Name { get; set; }

        T Value { get; set; }
    }
}