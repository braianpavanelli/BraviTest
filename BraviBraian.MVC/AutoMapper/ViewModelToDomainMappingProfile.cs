using AutoMapper;
using BraviBraian.Domain.Entities;
using BraviBraian.MVC.ViewModels;

namespace BraviBraian.MVC.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<Person, PersonViewModel>();
            CreateMap<Contact, ContactViewModel>();
            CreateMap<ContactType, ContactTypeViewModel>();
        }

        public override string ProfileName
        {
            get { return "DomainToViewModelMappings"; }
        }
    }
}