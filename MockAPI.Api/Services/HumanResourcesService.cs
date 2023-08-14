using MockAPI.Domain;
using MockAPI.Data;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlTypes;
using System.Xml;
using System.Xml.Linq;
using MockAPI.Api.RequestResponseObjects;

namespace MockAPI.Api.Services
{
    public class HumanResourcesService
    {
        private readonly MockAPIContext db;

        public HumanResourcesService(MockAPIContext dbContext)
        {
            db = dbContext;
        }

        public GetEmployeeResponse GetEmployee(int BusinessEntityId)
        {
                return db.Employees
                .Where(employee => employee.BusinessEntityId == BusinessEntityId)
                .Select(employee => new GetEmployeeResponse
                {
                    BusinessEntity = db.BusinessEntities.Where(businessEntity => employee.BusinessEntityId == BusinessEntityId).Select(businessEntity => businessEntity).First(),
                    NationalIdNumber = employee.NationalIdNumber,
                    LoginId = employee.LoginId,
                    OrganizationLevel = employee.OrganizationLevel,
                    JobTitle = employee.JobTitle,
                    BirthDate = employee.BirthDate,
                    MaritalStatus = employee.MaritalStatus,
                    Gender = employee.Gender,
                    HireDate = employee.HireDate,
                    SalariedFlag = employee.SalariedFlag,
                    VacationHours = employee.VacationHours,
                    SickLeaveHours = employee.SickLeaveHours,
                    CurrentFlag = employee.CurrentFlag,
                    ModifiedDate = employee.ModifiedDate,
                }).First();
        }

        public List<DepartmentHistory> GetDepartmentHistories(int BusinessEntityId)
        {
                return db.DepartmentHistories
                .Where(departmentHistory => departmentHistory.BusinessEntity.BusinessEntityId == BusinessEntityId)
                .ToList();
        }

        public List<PayHistory> GetPayHistories(int BusinessEntityId)
        {
                return db.PayHistories
                .Where(payHistory => payHistory.BusinessEntity.BusinessEntityId == BusinessEntityId)
                .ToList();
        }

        public List<PayHistory> GetPayHistories(decimal Lowerbound)
        {
                return db.PayHistories
                .Where(payHistory => payHistory.Rate > Lowerbound)
                .ToList();
        }

        public List<PayHistory> GetPayHistories(decimal Lowerbound, decimal UpperBound)
        {
                return db.PayHistories
                .Where(payHistory => payHistory.Rate > Lowerbound && payHistory.Rate < UpperBound)
                .ToList();
        }

        public string GetJobCandidateResumeByJobCandidateId(int JobCandidateId)
        {
            return db.JobCandidates
            .Where(jobCandidate => jobCandidate.JobCandidateId == JobCandidateId)
            .Select(jobCandidate => jobCandidate.Resume)
            .First();

        }

        public string GetJobCandidateResumeByBusinessEntityId(int BusinessEntityId)
        {
            return db.JobCandidates
                .Where(jobCandidate => jobCandidate.BusinessEntity.BusinessEntityId == BusinessEntityId)
                .Select(jobCandidate => jobCandidate.Resume)
                .First();
        }

        public List<string> GetJobCandidateResumeByName(string Lastname, string Firstname)
        {
            return db.People
                .Include(people => people.BusinessEntity)
                .ThenInclude(businessEntity => businessEntity.JobCandidate)
                .ThenInclude(jobCandidate => jobCandidate.Resume)
                .Where(person => person.FirstName == Firstname && person.LastName == Lastname)
                .Select(person => person.BusinessEntity.JobCandidate.Resume)
                .ToList();
        }
    }
}
