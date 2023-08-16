﻿using MockAPI.Data;
using MockAPI.Api.RequestResponseObjects;
using MockAPI.Domain;

namespace MockAPI.Api.Services
{
    public class PeopleService
    {
        private readonly MockAPIContext db;

        public PeopleService(MockAPIContext dbContext)
        {
            db = dbContext;
        }

        public GetPersonResponse GetPerson(int BusinessEntityId)
        {
                return db.People
                .Where(person => person.BusinessEntityId == BusinessEntityId)
                .Select(person => new GetPersonResponse
                {
                    BusinessEntity = db.BusinessEntities.Where(businessEntity => businessEntity.BusinessEntityId == BusinessEntityId).Select(businessEntity => businessEntity).First(),
                    PersonType = person.PersonType,
                    NameStyle = person.NameStyle,
                    Title = person.Title,
                    FirstName = person.FirstName,
                    MiddleName = person.MiddleName,
                    LastName = person.LastName,
                    Suffix = person.Suffix,
                    EmailPromotion = person.EmailPromotion,
                    RowGuid = person.RowGuid,
                    ModifiedDate = person.ModifiedDate,
                })
                .First();
        }

        public GetPersonResponse GetPersonByName(string FirstName, string LastName) 
        {
            return db.People
                .Where(person => person.FirstName == FirstName && person.LastName == LastName)
                .Select(person => new GetPersonResponse
                {
                    BusinessEntity = person.BusinessEntity,
                    PersonType = person.PersonType,
                    NameStyle = person.NameStyle,
                    Title = person.Title,
                    FirstName = person.FirstName,
                    MiddleName = person.MiddleName,
                    LastName = person.LastName,
                    Suffix = person.Suffix,
                    EmailPromotion = person.EmailPromotion,
                    RowGuid = person.RowGuid,
                    ModifiedDate = person.ModifiedDate,
                })
                .First();
        }

        public CreatePersonRequest CreatePerson(CreatePersonRequest newPerson)
        {
            var person = new Person
            {
                PersonType = newPerson.PersonType,
                NameStyle = newPerson.NameStyle,
                Title = newPerson.Title,
                FirstName = newPerson.FirstName,
                MiddleName = newPerson.MiddleName,
                LastName = newPerson.LastName,
                Suffix = newPerson.Suffix,
                EmailPromotion = newPerson.EmailPromotion,
                RowGuid = newPerson.RowGuid,
                ModifiedDate = DateTime.Now,
            };
           db.People.Add(person);
            db.SaveChanges();
            return (newPerson);
        }

    }
}
