using MockAPI.Domain;
using System.Data.SqlTypes;
using System.Xml;
using System.Xml.Linq;

namespace MockAPI.Api.RequestResponseObjects
{
    public class GetPersonResponse
    {
        public BusinessEntity BusinessEntity { get; set; }
        public string PersonType { get; set; }
        public Boolean NameStyle { get; set; }
        public string? Title { get; set; }
        public string FirstName { get; set; }
        public char? MiddleName { get; set; }
        public string LastName { get; set; }
        public string? Suffix { get; set; }
        public int EmailPromotion { get; set; }
        public Guid RowGuid { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
