﻿using MockAPI.Domain;
using System.Xml;

namespace MockAPI.Api.RequestResponseObjects
{
    public class GetPersonResponse
    {
        public BusinessEntity BusinessEntity { get; set; }
        public string PersonType { get; set; }
        public int NameStyle { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public char MiddleName { get; set; }
        public string LastName { get; set; }
        public string Suffix { get; set; }
        public int EmailPromotion { get; set; }
        public XmlDocument AdditonalContactInfo { get; set; }
        public XmlDocument Demographics { get; set; }
        public string RowGuid { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
