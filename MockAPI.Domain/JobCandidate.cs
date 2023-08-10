using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace MockAPI.Domain
{
    public class JobCandidate
    {
        public int Id { get; set; }
        public int JobCandidateId { get; set; }
        public BusinessEntity BusinessEntity { get; set; }
        public XmlDocument Resume { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
