using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace MockAPI.Domain
{
    public class Person
    {
        public int Id { get; set; }
        public int BusinessEntityId { get; set; }
        public string PersonType { get; set; }
        public int NameStyle { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public char MiddleName { get; set; }
        public string LastName { get; set; }
        public string suffix { get; set; }
        public int EmailPromotion { get; set; }
        public XmlDocument AdditonalContactInfo { get; set; }
        public XmlDocument Demogaphics { get; set; }
        public string rowguid { get; set; }
        public DateTime ModifiedDate { get; set; }

    }
}
