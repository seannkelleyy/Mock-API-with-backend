using System.Data.SqlTypes;
using System.Xml;
using System.Xml.Linq;

namespace MockAPI.Domain
{
    public class JobCandidate
    {
        public int Id { get; set; }
        public int JobCandidateId { get; set; }
        public BusinessEntity BusinessEntity { get; set; }
        public XDocument Resume { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
