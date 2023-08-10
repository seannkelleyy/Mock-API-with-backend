using MockAPI.Domain;

namespace MockAPI.Api.RequestResponseObjects
{
    public class GetPayHistoryResponse
    {
        public BusinessEntity BusinessEntity { get; set; }
        public DateTime RateChangeDay { get; set; }
        public decimal Rate { get; set; }
        public int PayFrequency { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
