using Microsoft.AspNetCore.Mvc;
using MockAPI.Api.Services;
using MockAPI.Data;

namespace MockAPI.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HumanResourcesController : ControllerBase
    {
        private readonly HumanResourcesService humanResources;
        public HumanResourcesController(MockAPIContext dbContext)
        {
            humanResources = new HumanResourcesService(dbContext);
        }

        [HttpGet("Employee/{BusinessEntityId:int}")]
        public IActionResult GetEmployee(int BusinessEntityId)
        {
            try
            {
                return Ok(humanResources.GetEmployee(BusinessEntityId));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
           }

        [HttpGet("DepartmentHistory/{BusinessEntityId:int}")]
        public IActionResult GetDepartmentHistories(int BusinessEntityId)
        {
            try
            {
                return Ok(humanResources.GetDepartmentHistories(BusinessEntityId));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("PayHistory/{BusinessEntityId:int}")]
        public IActionResult GetPayHistoriesForEmployee(int BusinessEntityId)
        {
            try
            {
                return Ok(humanResources.GetPayHistories(BusinessEntityId));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("PayHistory/{LowerBound:decimal}")]
        public IActionResult GetPayHistoriesByLowerBound(decimal LowerBound)
        {
            try
            {
                return Ok(humanResources.GetPayHistories(LowerBound));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("PayHistory/")]
        public IActionResult GetPayHistoriesByLowerAndUpperBound([FromQuery]decimal LowerBound, decimal UpperBound)
        {
            try
            {
                return Ok(humanResources.GetPayHistories(LowerBound, UpperBound));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("JobCandidateResume/{BusinessEntityId:int}")]
        public IActionResult GetJobCandidateResumeByBusinessEntityId(int BusinessEntityId)
        {
            try
            {
                return Ok(humanResources.GetJobCandidateResumeByBusinessEntityId(BusinessEntityId));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("JobCandidateResume/")]
        public IActionResult GetJobCandidateResumeByName([FromQuery]string Lastname, string Firstname)
        {
            try
            {
                return Ok(humanResources.GetJobCandidateResumeByName(Lastname, Firstname));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            } 
        }
    }
}
