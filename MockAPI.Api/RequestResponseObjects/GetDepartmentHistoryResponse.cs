using MockAPI.Domain;

namespace MockAPI.Api.RequestResponseObjects
{
    public class GetDepartmentHistoryResponse
    {
        public BusinessEntity BusinessEntity { get; set; }
        public int DepartmentId { get; set; }
        public int ShiftId { get; set; }
        public DateOnly StartDate { get; set; }
        public DateOnly EndDate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
