using Cache.Application.DTOs;
using Cache.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Cache.Api.Controllers
{
    [ApiController]
    [Route("api/person")]
    public class PersonController : ControllerBase
    {
        IPersonService _personService;
        public PersonController(IPersonService personService)
        {
            _personService = personService;
        }
        [HttpGet]
        public IEnumerable<PersonDto> GetAllPersons()
        {
            return _personService.GetAllPersons();
        }
        public PersonDto GetPersonBySsn(int ssn)
        {
            return _personService.GetPersonBySsn(ssn);
        }

        [HttpPost]
        public IActionResult Insert([FromBody] PersonDto personDto)
        {
            _personService.InsertPerson(personDto);
            return StatusCode(201);
        }
    }
}
