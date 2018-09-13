using _3DProject.Interfaces;

namespace _3DProject.Repository
{
    public class Repository<T> : IStuffRepository<T>
    {
        public string Create(IThing<T> thing)
        {
            throw new System.NotImplementedException();
        }

        public bool Delete(IThing<T> thing)
        {
            throw new System.NotImplementedException();
        }

        public IThing<T> Get(string key)
        {
            throw new System.NotImplementedException();
        }

        public void Update(IThing<T> thing)
        {
            throw new System.NotImplementedException();
        }
    }

}
