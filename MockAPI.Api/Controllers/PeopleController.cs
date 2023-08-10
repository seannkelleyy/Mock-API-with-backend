using Microsoft.AspNetCore.Mvc;
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

        [HttpGet("Person")]
        public IActionResult GetPerson(int BusinessEntityId)
        {
            try
            {
                return Ok(people.GetPerson(BusinessEntityId));
            }
            catch (Exception ex)
            {
                return StatusCode(500);
            }
        }
    }
}
