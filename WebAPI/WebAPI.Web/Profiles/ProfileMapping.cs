using AutoMapper;
using WebAPI.Web.Models.DTO;
using WebAPI.Web.Models.PokemonModel;

namespace WebAPI.Web.Profiles
{
    public class ProfileMapping:Profile
    {
        public ProfileMapping()
        {
            CreateMap<Pokemon, PokemonDTO>();
            CreateMap<Category, CategoryDTO>();

        }
    }
}
