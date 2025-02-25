using AutoMapper;
using Rira_Task.Application.DTOs.Person;
using Rira_Task.Domain;

namespace Rira_Task.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {

            #region Personnel

            CreateMap<Person, PersonDto>().ReverseMap();
            CreateMap<Person, PersonListDto>().ReverseMap();
            CreateMap<Person, CreatePersonDto>().ReverseMap();
            CreateMap<Person, UpdatePersonDto>().ReverseMap();


            #endregion

        }

    }
}
