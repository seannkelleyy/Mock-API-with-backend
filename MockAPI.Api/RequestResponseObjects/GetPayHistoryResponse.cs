using MockAPI.Domain;

namespace MockAPI.Api.RequestResponseObjects
{
    public class GetPayHistoryResponse
    {
        public BusinessEntity? BusinessEntity { get; set; }
        public DateTime RateChangeDate { get; set; }
        public decimal Rate { get; set; }
        public Byte PayFrequency { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
