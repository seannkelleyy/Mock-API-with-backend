namespace MockAPI.Domain
{
    public class PayHistory
    {
        public int Id { get; set; }
        public BusinessEntity BusinessEntity { get; set; }
        public DateTime RateChangeDay { get; set; }
        public decimal Rate { get; set; }
        public int PayFrequency { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
