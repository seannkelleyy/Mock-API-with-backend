using MockAPI.Domain;

namespace MockAPI.Api.RequestResponseObjects
{
    public class GetDepartmentHistoryResponse
    {
        public BusinessEntity BusinessEntity { get; set; }
        public int DepartmentId { get; set; }
        public int ShiftId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
