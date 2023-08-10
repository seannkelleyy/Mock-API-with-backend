using MockAPI.Domain;
using SnackTrack.Data;
using System.Xml;

namespace MockAPI.Api.Services
{
    public class HumanResourcesService
    {
        private readonly MockAPIContext db;

        public HumanResourcesService(MockAPIContext dbContext)
        {
            db = dbContext;
        }

        public Employee GetEmployee(int BusinessEntityId)
        {
            var employee = new Employee();

            if (BusinessEntityId != null)
            {
                employee = db.Employees.Find(BusinessEntityId);
            }

            return employee;
        }

        public List<DepartmentHistory> GetDepartmentHistory(int BusinessEntityId)
        {
            var departmentHistory = new List<DepartmentHistory>();

            if (BusinessEntityId != null)
            {
                departmentHistory = db.DepartmentHistories.Where(departmentHistory => departmentHistory.BusinessEntity.Id == BusinessEntityId).ToList();
            }

            return departmentHistory;
        }

        public List<PayHistory> GetPayHistories(int BusinessEntityId)
        {
            var payHistory = new List<PayHistory>();

            if (BusinessEntityId != null)
            {
                payHistory = db.PayHistories.Where(payHistory => payHistory.BusinessEntity.Id == BusinessEntityId).ToList();
            }

            return payHistory;
        }

        public List<PayHistory> GetPayHistories(decimal Lowerbound)
        {
            var payHistory = new List<PayHistory>();

            if (Lowerbound != null)
            {
                payHistory = db.PayHistories.Where(payHistory => payHistory.Rate > Lowerbound).ToList();
            }

            return payHistory;
        }

        public List<PayHistory> GetPayHistories(decimal Lowerbound, decimal UpperBound)
        {
            var payHistory = new List<PayHistory>();

            if (Lowerbound != null && UpperBound != null)
            {
                payHistory = db.PayHistories.Where(payHistory => payHistory.Rate > Lowerbound && payHistory.Rate < UpperBound).ToList();
            }

            return payHistory;
        }

        public XmlDocument GetJobCandidateResumeByJobCandidateId(int JobCandidateId)
        {
            var jobCandidateResume = new XmlDocument();

            if (JobCandidateId != null)
            {
                jobCandidateResume = db.JobCandidates.Find(JobCandidateId).Resume;
            }

            return jobCandidateResume;
        }

        public XmlDocument GetJobCandidateResumeByBusinessEntityId(int BusinessEntityId)
        {
            var jobCandidateResume = new XmlDocument();

            if (BusinessEntityId != null)
            {
                jobCandidateResume = db.JobCandidates.Where(jobCandidate => jobCandidate.BusinessEntity.Id == BusinessEntityId).Select(jobCandidate => jobCandidate.Resume).First();
            }

            return jobCandidateResume;
        }

        /*
         * This method returns a list of resumes because there could be multiple candidates with the same first and last name, which if you provide an id this isn't an issue becuase they are unique.
         */
        public List<XmlDocument> GetJobCandidateResumeByName(string Lastname, string Firstname)
        {
            var jobCandidateResume = new List<XmlDocument>();

            var people = new List<Person>();

            if (Firstname != null && Lastname != null)
            {
                people = db.People.Where(person => person.FirstName == Firstname && person.LastName == Lastname).ToList();
            }

            if (people != null)
            {
                List<int> BusinessEntityIds = people.Select(person => person.BusinessEntity.Id).ToList();

                foreach (int businessEntityId in BusinessEntityIds)
                {
                    jobCandidateResume.Add(db.JobCandidates.Where(jobCandidate => jobCandidate.BusinessEntity.Id == businessEntityId).Select(jobCandidate => jobCandidate.Resume).First());
                }
            }

            return jobCandidateResume;
        }
    }
}
