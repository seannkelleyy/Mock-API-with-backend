using System.ComponentModel.DataAnnotations;

namespace MockAPI.Domain
{
    public class DepartmentHistory
    {
        [Key]
        public int BusinessEntityId { get; set; }
        public BusinessEntity BusinessEntity { get; set; }
        public Int16 DepartmentId { get; set; }
        public Byte ShiftId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
