using Microsoft.AspNetCore.Mvc;
using MockAPI.Api.RequestResponseObjects;
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

        [HttpPost("Employee/")]
        public IActionResult CreateEmployee([FromBody] CreateEmployeeRequest Employee)
        {
            try
            {
                return Ok(humanResources.CreateEmployee(Employee));
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

        [HttpGet("PayHistory/BusinessEntity/{BusinessEntityId:int}")]
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

        [HttpGet("PayHistory/Lowerbound/{LowerBound:decimal}")]
        public IActionResult GetPayHistoriesByLowerBound(decimal LowerBound)
        {
            try
            {
                return Ok(humanResources.GetPayHistoriesMin(LowerBound));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("PayHistory/Range/{UpperBound:decimal}")]
        public IActionResult GetPayHistoriesByLowerAndUpperBound([FromQuery] decimal LowerBound, decimal UpperBound)
        {
            try
            {
                return Ok(humanResources.GetPayHistoriesRange(LowerBound, UpperBound));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPost("PayHistory/NewPaymentHistory/")]
        public IActionResult CreatePaymentHistory(CreatePayHistoryRequest newPayHistory)
        {
            try
            {
                return Ok(humanResources.CreatePaymentHistory(newPayHistory));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPost("JobCandidate/BusinessEntityId/")]
        public IActionResult CreateJobCandidate(CreateJobCandidateRequest newCandidate)
        {
            try
            {
                return Ok(humanResources.CreateJobCandidate(newCandidate));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        
        [HttpGet("JobCandidateResume/JobCandidateId/{JobCandidateId:int}")]
        public IActionResult GetJobCandidateResumeByJobCandidateId(int JobCandidateId)
        {
            try
            {
                return Ok(humanResources.GetJobCandidateResumeByJobCandidateId(JobCandidateId));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("JobCandidateResume/BusinessEntityId/{BusinessEntityId:int}")]
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

        [HttpGet("JobCandidateResume/Name/")]
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
