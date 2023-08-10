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
            var person = new Person();

            if (BusinessEntityId != null)
            {
                person = db.People.Find(BusinessEntityId);
            }

            return person;
        }
    }
}
