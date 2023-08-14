using System.ComponentModel.DataAnnotations;

namespace MockAPI.Domain
{
    public class DepartmentHistory
    {
        [Key]
        public int BusinessEntityId { get; set; }
        public BusinessEntity BusinessEntity { get; set; }
        public int DepartmentId { get; set; }
        public int ShiftId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
