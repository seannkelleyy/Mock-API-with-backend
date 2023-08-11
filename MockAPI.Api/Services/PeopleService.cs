using MockAPI.Domain;
using MockAPI.Data;
using System.Xml;

namespace MockAPI.Api.Services
{
    public class PeopleService
    {
        private readonly MockAPIContext db;

        public PeopleService(MockAPIContext dbContext)
        {
            db = dbContext;
        }

        public Person GetPerson(int BusinessEntityId)
        {
                return db.People
                .Where(person => person.BusinessEntity.BusinessEntityId == BusinessEntityId)
                .Select(person => person)
                .First();
        }
    }
}
