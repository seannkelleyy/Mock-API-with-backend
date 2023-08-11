using System.Data.SqlTypes;
using System.Xml;
using System.Xml.Linq;

namespace MockAPI.Domain
{
    public class Person
    {
        public int Id { get; set; }
        public BusinessEntity BusinessEntity { get; set; }
        public string PersonType { get; set; }
        public int NameStyle { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public char MiddleName { get; set; }
        public string LastName { get; set; }
        public string Suffix { get; set; }
        public int EmailPromotion { get; set; }
        public string AdditonalContactInfo { get; set; }
        public string Demographics { get; set; }
        public string RowGuid { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
