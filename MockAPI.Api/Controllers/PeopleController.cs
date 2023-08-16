using Microsoft.AspNetCore.Mvc;
using MockAPI.Api.RequestResponseObjects;
using MockAPI.Api.Services;
using MockAPI.Data;

namespace MockAPI.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PeopleController : ControllerBase
    {
        private readonly PeopleService people;
        public PeopleController(MockAPIContext dbContext)
        {
            people = new PeopleService(dbContext);
        }

        [HttpGet("Person/{BusinessEntityId:int}")]
        public IActionResult GetPerson(int BusinessEntityId)
        {
            try
            {
                return Ok(people.GetPerson(BusinessEntityId));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("Person/Name/")]
        public IActionResult GetPersonByName([FromQuery] string FirstName, string LastName) 
        {
              try
            {
                return Ok(people.GetPersonByName(FirstName, LastName));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPost("Person/Create/")]
        public IActionResult CreatePerson(CreatePersonRequest newPerson)
        {
            try
            {
                return Ok(people.CreatePerson(newPerson));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
