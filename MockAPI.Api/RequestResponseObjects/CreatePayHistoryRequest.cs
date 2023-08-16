namespace MockAPI.Api.RequestResponseObjects
{
    public class CreatePayHistoryRequest
    {
        public int BusinessEntityId { get; set; }
        public DateTime RateChangeDate { get; set; }
        public decimal Rate { get; set; }
        public Byte PayFrequency { get; set; }

    }
}
