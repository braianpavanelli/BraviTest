using BraviBraian.Domain.Interfaces.Repositories;
using BraviBraian.Infra.Data.Repository;
using SimpleInjector;

namespace BraviBraian.Infra.IoC
{
    public class BootStrapper
    {
        public static void RegisterServices(Container container)
        {
            container.Register(typeof(IBaseRepository<>), typeof(BaseRepository<>), Lifestyle.Scoped);
            container.Register<IPersonRepository, PersonRepository>(Lifestyle.Singleton);
            container.Register<IContactRepository, ContactRepository>(Lifestyle.Singleton);
            container.Register<IContactTypeRepository, ContactTypeRepository>(Lifestyle.Singleton);
        }
    }
}
