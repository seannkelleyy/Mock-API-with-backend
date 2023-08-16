using MockAPI.Domain;

namespace MockAPI.Api.RequestResponseObjects
{
    public class CreateJobCandidateRequest
    {
        public int BusinessEntityId { get; set; }
        public string? Resume { get; set; }
    }
}
