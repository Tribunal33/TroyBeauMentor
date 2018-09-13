namespace _3DProject.Interfaces
{
    public interface IStuffRepository<T>
    {
        IThing<T> Get(string key);

        string Create(IThing<T> thing);

        void Update(IThing<T> thing);

        bool Delete(IThing<T> thing);
    }
}
