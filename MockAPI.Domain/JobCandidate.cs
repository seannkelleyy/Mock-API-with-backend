using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;
using System.Xml;
using System.Xml.Linq;

namespace MockAPI.Domain
{
    public class JobCandidate
    {
        [Key]
        public int JobCandidateId { get; set; }
        public int? BusinessEntityId { get; set; }
        public BusinessEntity? BusinessEntity { get; set; }
        public string? Resume { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
