using MockAPI.Data;
using MockAPI.Api.RequestResponseObjects;

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
    }
}
