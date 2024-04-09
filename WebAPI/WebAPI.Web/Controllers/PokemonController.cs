using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Web.Logging;
using WebAPI.Web.Models.DTO;
using WebAPI.Web.Models.PokemonModel;
using WebAPI.Web.Models.Repositories;

namespace WebAPI.Web.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PokemonController : ControllerBase
    {
        private readonly IPokemonRepository _pokemon;
        private readonly IMapper _mapper;
        private readonly ILogClass _logger;
        public PokemonController(IPokemonRepository pokemon,IMapper mapper,
            ILogClass logger)
        {
                _pokemon = pokemon; 
            _mapper = mapper;
            _logger= logger;    
        }
        [HttpGet]
        [ProducesResponseType(200,Type=typeof(IEnumerable<Pokemon>))]
        public IActionResult PokemonList()
        {
          var pokemon=_mapper.Map<List<PokemonDTO>>(_pokemon.GetPokemonList());
            if(!ModelState.IsValid)
                return BadRequest(ModelState);
            //custom logging 
            _logger.LogMethod("Its Ok request","");
            return Ok(pokemon);                 
        }
        [HttpGet("{id}")]
        [ProducesResponseType(200,Type=typeof(Pokemon))]
        [ProducesResponseType(400)]
        public IActionResult ExistPokimon(int id)
        {
            if (!_pokemon.PokemonExists(id))
            {
                _logger.LogMethod(" not foundlog ", "error");
                return NotFound("This type of pokemon was not found");
            }

            var isExist=_mapper.Map<PokemonDTO>(_pokemon.PokemonExists(id));

            if(!ModelState.IsValid) 
                return BadRequest(ModelState);

            return Ok(isExist);
        }
        [HttpGet("{id}/rating")]
        [ProducesResponseType(200,Type=typeof(Pokemon))]
        [ProducesResponseType(400)]
        public IActionResult GetRating(int id) 
        {
            if (!_pokemon.PokemonExists(id))
                return NotFound("pokeman is not in here");

            var rating=_pokemon.GetPokemonRating(id);
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(rating);      
        }


    }
}
