namespace MockAPI.Domain
{
    public class DepartmentHistory
    {
        public int Id { get; set; }
        public BusinessEntity BusinessEntity { get; set; }
        public int DepartmentId { get; set; }
        public int ShiftId { get; set; }
        public DateOnly StartDate { get; set; }
        public DateOnly EndDate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
