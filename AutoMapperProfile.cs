using AutoMapper;
using dotnet_rpg_dotNET50_.Dtos.Character;
using dotnet_rpg_dotNET50_.Models;

namespace dotnet_rpg_dotNET50_
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Character, GetCharacterDto>();
            CreateMap<AddCharacterDto, Character>();

        }
    }
}