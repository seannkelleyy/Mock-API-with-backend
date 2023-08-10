using MockAPI.Domain;
using System.Xml;

namespace MockAPI.Api.RequestResponseObjects
{
    public class GetJobCandidateResponse
    {
        public int Id { get; set; }
        public int JobCandidateId { get; set; }
        public BusinessEntity BusinessEntity { get; set; }
        public XmlDocument Resume { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
