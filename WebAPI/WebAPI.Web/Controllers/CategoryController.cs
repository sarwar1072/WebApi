using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Web.Models.DTO;
using WebAPI.Web.Models.PokemonModel;
using WebAPI.Web.Models.Repositories;

namespace WebAPI.Web.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryRepository _category;
        private IMapper _mapper;
        public CategoryController(ICategoryRepository category, IMapper mapper)
        {
            _category = category;
            _mapper = mapper;
        }
        [HttpGet("{id}")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Pokemon>))]
        public IActionResult GetpokemonById(int id)
        {
            var count = _mapper.Map<List<PokemonDTO>>(_category.GetPokemonByCategoryId(id));
            if (count == null)
            {
                return NotFound("no category found");  
            }
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(count);          
        }

        [HttpGet("{id}")]
        [ProducesResponseType(200, Type = typeof(Category))]
        public IActionResult GetAllCAtegory(int id)
        {
            var count = _mapper.Map<CategoryDTO>(_category.GetCategoryById(id));
            if (count == null)
            {
                return NotFound("no category found");
            }
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(count);
        }


    }
}
