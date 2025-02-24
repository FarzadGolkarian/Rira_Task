using AutoMapper;
using Rira_Task.Application.DTOs.Person;
using Rira_Task.Application.Responses;
using Rira_Task.Grpc.Protos;

namespace Rira_Task.Grpc.Mapper.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {

            #region PersonnelProto

            CreateMap<ProtoPersonDto, PersonDto>().ReverseMap();
            CreateMap<CreatePersonCommand, CreatePersonDto>().ReverseMap();
            CreateMap<Response, BaseCommandResponse>().ReverseMap();

            #endregion



        }

    }
}
