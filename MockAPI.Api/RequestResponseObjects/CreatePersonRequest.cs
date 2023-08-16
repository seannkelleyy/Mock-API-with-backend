﻿namespace MockAPI.Api.RequestResponseObjects
{
    public class CreatePersonRequest
    {
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