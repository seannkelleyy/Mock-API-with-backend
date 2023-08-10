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

        [HttpGet]
        public IActionResult GetEmployee(int BusinessEntityId)
        {
            try
            {
                return Ok(humanResources.GetEmployee(BusinessEntityId));
            }
            catch (Exception ex)
            {
                return StatusCode(500);
            }
        }

        [HttpGet]
        public IActionResult GetDepartmentHistories(int BusinessEntityId)
        {
            try
            {
                return Ok(humanResources.GetDepartmentHistories(BusinessEntityId));
            }
            catch (Exception ex)
            {
                return StatusCode(500);
            }
        }

        [HttpGet]
        public IActionResult GetPayHistories(int BusinessEntityId)
        {
            try
            {
                return Ok(humanResources.GetPayHistories(BusinessEntityId));
            }
            catch (Exception ex)
            {
                return StatusCode(500);
            }
        }

        [HttpGet]
        public IActionResult GetPayHistories(decimal LowerBound)
        {
            try
            {
                return Ok(humanResources.GetPayHistories(LowerBound));
            }
            catch (Exception ex)
            {
                return StatusCode(500);
            }
        }

        [HttpGet]
        public IActionResult GetPayHistories(decimal LowerBound, decimal UpperBound)
        {
            try
            {
                return Ok(humanResources.GetPayHistories(LowerBound, UpperBound));
            }
            catch (Exception ex)
            {
                return StatusCode(500);
            }
        }

        [HttpGet]
        public IActionResult GetJobCandidateResumeByJobCandidateId(int JobCandidateId)
        {
            try
            {
                return Ok(humanResources.GetJobCandidateResumeByJobCandidateId(JobCandidateId));
            }
            catch (Exception ex)
            {
                return StatusCode(500);
            }
        }

        [HttpGet]
        public IActionResult GetJobCandidateResumeByBusinessEntityId(int BusinessEntityId)
        {
            try
            {
                return Ok(humanResources.GetJobCandidateResumeByBusinessEntityId(BusinessEntityId));
            }
            catch (Exception ex)
            {
                return StatusCode(500);
            }
        }

        [HttpGet]
        public IActionResult GetJobCandidateResumeByName(string Lastname, string Firstname)
        {
            try
            {
                return Ok(humanResources.GetJobCandidateResumeByName(Lastname, Firstname));
            }
            catch (Exception ex)
            {
                return StatusCode(500);
            }
        }
    }
}
