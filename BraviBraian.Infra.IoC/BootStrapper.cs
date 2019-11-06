using BraviBraian.Application;
using BraviBraian.Application.Interface;
using BraviBraian.Domain.Interfaces.Repositories;
using BraviBraian.Domain.Interfaces.Services;
using BraviBraian.Domain.Services;
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

            container.Register(typeof(IBaseService<>), typeof(BaseService<>), Lifestyle.Scoped);
            container.Register<IPersonService, PersonService>(Lifestyle.Singleton);
            container.Register<IContactService, ContactService>(Lifestyle.Singleton);
            container.Register<IContactTypeService, ContactTypeService>(Lifestyle.Singleton);

            container.Register(typeof(IAppBaseService<>), typeof(AppBaseService<>), Lifestyle.Scoped);
            container.Register<IPersonAppService, PersonAppService>(Lifestyle.Singleton);
            container.Register<IContactAppService, ContactAppService>(Lifestyle.Singleton);
            container.Register<IContactTypeAppService, ContactTypeAppService>(Lifestyle.Singleton);
        }
    }
}
