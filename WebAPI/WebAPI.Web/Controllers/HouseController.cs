using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Web.Models.DTO;
using WebAPI.Web.Models.PokemonModel;
using WebAPI.Web.Models.VillaRepository;
using WebAPI.Web.Models.VillaModel;
using System.Net;

namespace WebAPI.Web.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class HouseController : ControllerBase
    {
        private readonly IHouseRepository _house;
        private IMapper _mapper;
        protected readonly APIResponse _response;
        public HouseController(IHouseRepository house,IMapper mapper)
        {
            _house = house;  
            _mapper = mapper;
            _response = new();
        }
        [HttpGet]
       // [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<House>))]
        public  IActionResult GetAll() 
        {
            var data=_mapper.Map<List<HouseDTO>>(_house.GetAll());
           // _response.StatusCode=HttpStatusCode.OK;  
            return Ok(data);
        }
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(House))]
        public IActionResult CreateHouse(HouseDTO houseDTO) 
        {           
            if (houseDTO == null)
            {
                _response.StatusCode = HttpStatusCode.BadRequest;
                return BadRequest(_response);
            }
                          
            var houseEntity = _mapper.Map<House>(houseDTO);
            _house.Add(houseEntity);
            _response.Result=_mapper.Map<HouseDTO>(houseEntity);
            return Ok(_response);         
        }
        [HttpPut]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(House))]
        public IActionResult UpdateHouse(HouseDTO houseDTO) 
        {
            if (houseDTO.Id == null)
            {
                _response.StatusCode = HttpStatusCode.NoContent;
                return NotFound(_response);
            }
                

            var houseEntity = _mapper.Map<House>(houseDTO);
            _house.Update(houseEntity);

            _response.StatusCode = HttpStatusCode.NoContent;
            
            return Ok(_response);   
        }

        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult DeleteHouse(int id)
        {
            var count=_mapper.Map<HouseDTO>(_house.GetById(id));
            if (count == null)
            {
                _response.StatusCode = HttpStatusCode.NoContent;
                return NotFound(_response);
            }
                
            if (count != null)
            {
                _house.Delete(_mapper.Map<House>(count));  
                _response.StatusCode= HttpStatusCode.OK;                
            }
            return Ok(_response);
        }

    }
}
