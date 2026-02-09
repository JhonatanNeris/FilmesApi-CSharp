using AutoMapper;
using FilmesApi.Data;
using FilmesApi.Data.Dtos;
using FilmesApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace FilmesApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AddressController : ControllerBase
    {
        private MovieContext _context;
        private IMapper _mapper;

        public AddressController(MovieContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult AddAddress([FromBody] CreateAddressDto enderecoDto)
        {
            Address endereco = _mapper.Map<Address>(enderecoDto);
            _context.Addresses.Add(endereco);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetAddressById), new { Id = endereco.Id }, endereco);
        }

        [HttpGet]
        public IEnumerable<ReadAddressDto> GetAddress()
        {
            return _mapper.Map<List<ReadAddressDto>>(_context.Addresses);
        }

        [HttpGet("{id}")]
        public IActionResult GetAddressById(int id)
        {
            Address endereco = _context.Addresses.FirstOrDefault(endereco => endereco.Id == id);
            if (endereco != null)
            {
                ReadAddressDto enderecoDto = _mapper.Map<ReadAddressDto>(endereco);

                return Ok(enderecoDto);
            }
            return NotFound();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateAddress(int id, [FromBody] UpdateAddressDto enderecoDto)
        {
            Address endereco = _context.Addresses.FirstOrDefault(endereco => endereco.Id == id);
            if (endereco == null)
            {
                return NotFound();
            }
            _mapper.Map(enderecoDto, endereco);
            _context.SaveChanges();
            return NoContent();
        }


        [HttpDelete("{id}")]
        public IActionResult DeleteAddress(int id)
        {
            Address endereco = _context.Addresses.FirstOrDefault(endereco => endereco.Id == id);
            if (endereco == null)
            {
                return NotFound();
            }
            _context.Remove(endereco);
            _context.SaveChanges();
            return NoContent();
        }

    }
}