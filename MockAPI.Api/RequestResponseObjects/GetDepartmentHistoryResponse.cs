using MockAPI.Domain;

namespace MockAPI.Api.RequestResponseObjects
{
    public class GetDepartmentHistoryResponse
    {
        public BusinessEntity BusinessEntity { get; set; }
        public Int16 DepartmentId { get; set; }
        public Byte ShiftId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
