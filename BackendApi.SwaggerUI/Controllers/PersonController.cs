using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BackendApi.Business.Abstract;
using BackendApi.Model.Dto;
using BackendApi.Model.Entity;

namespace BackendApi.SwaggerUI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IPersonService _personService;
        private readonly IMapper _mapper;

        public PersonController(IPersonService personService, IMapper mapper)
        {
            _personService = personService;
            _mapper = mapper;
        }
       

        [HttpGet]
        public IActionResult GetAll()
        {
            var personList = _personService.PersonList();
            return Ok(personList);
        }

        [HttpGet("{id}", Name = "GetById")]
        public IActionResult GetById(int id)
        {
            var person = _personService.PersonGetId(id);
            if (person == null)
            {
                return BadRequest("Erorrr");
            }

            return Ok(person);
        }

        [HttpPost]
        public IActionResult Create([FromBody] PersonDto model)
        {
            if (model == null)
            {
                return BadRequest("Person is Null!!!!");
            }

            var mdl = _mapper.Map<Person>(model);
            _personService.Create(mdl);

            return Ok(mdl);

        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] Person person)
        {
            if (person == null)
            {
                return BadRequest("erorr");
            }

            Person entity = _personService.PersonGetId(id);
            if (entity == null)
            {
                return BadRequest("erorr");
            }

            entity.Adi = person.Adi;
            entity.Soyadi = person.Soyadi;

            _personService.Update(entity);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Person person = _personService.PersonGetId(id);

            if (person == null)
            {
                return NotFound("The Person record could not be found");
            }

            _personService.Delete(person);
            return NoContent();

        }
    }
}