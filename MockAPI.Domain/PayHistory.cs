using System.ComponentModel.DataAnnotations;

namespace MockAPI.Domain
{
    public class PayHistory
    {
        [Key]
        public int BusinessEntityId { get; set; }
        public BusinessEntity BusinessEntity { get; set; }
        public DateTime RateChangeDate { get; set; }
        public decimal Rate { get; set; }
        public Byte PayFrequency { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
