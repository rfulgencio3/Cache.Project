using AutoMapper;
using Cache.Application.DTOs;
using Cache.Domain.Entities;

namespace Cache.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Person, PersonDto>();
        }
    }
}
