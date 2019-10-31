using AutoMapper;
using BraviBraian.Domain.Entities;
using BraviBraian.MVC.ViewModels;

namespace BraviBraian.MVC.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<PersonViewModel, Person>();
            CreateMap<ContactViewModel, Contact>();
            CreateMap<ContactTypeViewModel, ContactType>();
        }

        public override string ProfileName
        {
            get { return "ViewModelToDomainMappings"; }
        }
    }
}