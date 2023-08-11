namespace MockAPI.Domain
{
    public class Employee
    {
        public int Id { get; set; }
        public BusinessEntity BusinessEntity { get; set; }
        public int NationalIdNumber { get; set; }
        public string LoginId { get; set; }
        public string OrganizationNode { get; set; }
        public int OrganizationLevel { get; set; }
        public string JobTitle { get; set; }
        public DateTime BirthDate { get; set; }
        public char MaritalStatus { get; set; }
        public char Gender { get; set; }
        public DateTime HireDate { get; set; }
        public int SalariedFlag { get; set; }
        public int VacationHours { get; set; }
        public int SickLeaveHours { get; set; }
        public int CurrentFlag { get; set; }
        public string RowGuid { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
    