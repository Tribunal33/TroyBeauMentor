using _3DProject.Interfaces;
using _3DProject.Repository;
using Unity;

namespace _3DProject.Web
{
    internal class Ioc
    {
        private static UnityContainer _container;
        public static UnityContainer Container
        {
            get
            {
                if (_container == null)
                {
                    _container = new UnityContainer();
                    Initialize();
                }
                return _container;
            }
        }

        private static void Initialize()
        {
            //container.RegisterType<IStuffRepository<IPerson>, PersonRepository>();
            Container.RegisterInstance<IStuffRepository<IPerson>>(new PersonRepository());
        }
    }
}