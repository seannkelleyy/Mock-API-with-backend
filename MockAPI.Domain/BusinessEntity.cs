using System.ComponentModel.DataAnnotations;

namespace MockAPI.Domain
{
    public class BusinessEntity
    {
        [Key]
        public int BusinessEntityId { get; set; }
        public Guid RowGuid { get; set; }
        public DateTime ModifiedDate { get; set; }
        public Employee Employee { get; set; }
        public JobCandidate JobCandidate { get; set; }
        public Person Person { get; set; }
        public List<DepartmentHistory> DepartmentHistories { get; set; }
        public List<PayHistory> PayHistories { get; set; }

    }
}
