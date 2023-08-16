using MockAPI.Domain;
using MockAPI.Data;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlTypes;
using System.Xml;
using System.Xml.Linq;
using MockAPI.Api.RequestResponseObjects;
using Microsoft.AspNetCore.Mvc;

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
                BusinessEntity = db.BusinessEntities.Where(businessEntity => businessEntity.BusinessEntityId == BusinessEntityId).Select(businessEntity => businessEntity).First(),
                NationalIdNumber = employee.NationalIdNumber,
                LoginId = employee.LoginId,
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

        public Employee CreateEmployee(CreateEmployeeRequest Employee)
        {
            var businessEntity = new BusinessEntity
            {
                ModifiedDate = DateTime.Now,
            };
            var employee = new Employee
            {
                BusinessEntityId = businessEntity.BusinessEntityId,
                NationalIdNumber = Employee.NationalIdNumber,
                LoginId = Employee.LoginId,
                JobTitle = Employee.JobTitle,
                BirthDate = Employee.BirthDate,
                MaritalStatus = Employee.MaritalStatus,
                Gender = Employee.Gender,
                HireDate = Employee.HireDate,
                VacationHours = 14,
                SickLeaveHours = 15,
                CurrentFlag = true,
                RowGuid = businessEntity.RowGuid,
                ModifiedDate = DateTime.Now,
            };
            db.BusinessEntities.Add(businessEntity);
            db.SaveChanges();
            db.Employees.Add(employee);
            db.SaveChanges();
            return (employee);
        }

        public List<GetDepartmentHistoryResponse> GetDepartmentHistories(int BusinessEntityId)
        {
                return db.DepartmentHistories
                .Where(departmentHistory => departmentHistory.BusinessEntityId == BusinessEntityId)
                .Select(departmentHistory => new GetDepartmentHistoryResponse
                {
                    BusinessEntity = db.BusinessEntities.Where(businessEntity => businessEntity.BusinessEntityId == BusinessEntityId).Select(businessEntity => businessEntity).First(),
                    DepartmentId = departmentHistory.DepartmentId,
                    ShiftId = departmentHistory.ShiftId,
                    StartDate = departmentHistory.StartDate,
                    EndDate = departmentHistory.EndDate,
                    ModifiedDate = departmentHistory.ModifiedDate,
                })
                .ToList();
        }

        public List<GetPayHistoryResponse> GetPayHistories(int BusinessEntityId)
        {
                return db.PayHistories
                .Where(payHistory => payHistory.BusinessEntity.BusinessEntityId == BusinessEntityId)
                .Select(payHistory => new GetPayHistoryResponse
                {
                    BusinessEntity = db.BusinessEntities.Where(businessEntity => businessEntity.BusinessEntityId == BusinessEntityId).Select(businessEntity => businessEntity).First(),
                    RateChangeDate = payHistory.RateChangeDate,
                    Rate = payHistory.Rate,
                    PayFrequency = payHistory.PayFrequency,
                    ModifiedDate = payHistory.ModifiedDate,
                })
                .ToList();
        }

        public List<GetPayHistoryResponse> GetPayHistoriesMin(decimal Lowerbound)
        {
                return db.PayHistories
                .Where(payHistory => payHistory.Rate > Lowerbound)
                .Select(payHistory => new GetPayHistoryResponse
                {
                    BusinessEntity = payHistory.BusinessEntity,
                    RateChangeDate = payHistory.RateChangeDate,
                    Rate = payHistory.Rate,
                    PayFrequency = payHistory.PayFrequency,
                    ModifiedDate = payHistory.ModifiedDate,
                })
                .ToList();
        }

        public List<GetPayHistoryResponse> GetPayHistoriesRange(decimal Lowerbound, decimal UpperBound)
        {
                return db.PayHistories
                .Where(payHistory => payHistory.Rate > Lowerbound && payHistory.Rate < UpperBound)
                .Select(payHistory => new GetPayHistoryResponse
                {
                    RateChangeDate = payHistory.RateChangeDate,
                    Rate = payHistory.Rate,
                    PayFrequency = payHistory.PayFrequency,
                    ModifiedDate = payHistory.ModifiedDate,
                })
                .ToList();
        }

        public PayHistory CreatePaymentHistory(CreatePayHistoryRequest newPayHistory)
        {
            var payHistory = new PayHistory
            {
                BusinessEntityId = newPayHistory.BusinessEntityId,
                RateChangeDate = newPayHistory.RateChangeDate,
                Rate = newPayHistory.Rate,
                PayFrequency = newPayHistory.PayFrequency
            };
        }

        public JobCandidate CreateJobCandidate(CreateJobCandidateRequest candidate)
        {
            var newCandidate = new JobCandidate
            {
                BusinessEntityId = candidate.BusinessEntityId,
                Resume = candidate.Resume,
                ModifiedDate = DateTime.Now,
            };
            db.JobCandidates.Add(newCandidate);
            db.SaveChanges();
            return (newCandidate);
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
                .Where(jobCandidate => jobCandidate.BusinessEntityId == BusinessEntityId)
                .Select(jobCandidate => jobCandidate.Resume)
                .First();
        }

        public List<string> GetJobCandidateResumeByName(string Lastname, string Firstname)
        {
            return db.People
                .Include(people => people.BusinessEntity)
                .ThenInclude(businessEntity => businessEntity.JobCandidate)
                .Where(person => person.FirstName == Firstname && person.LastName == Lastname)
                .Select(person => person.BusinessEntity.JobCandidate.Resume)
                .ToList();
        }
    }
}
