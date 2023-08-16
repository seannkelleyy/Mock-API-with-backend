using Microsoft.SqlServer.Types;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;

namespace MockAPI.Domain
{
    public class Employee
    {
        [Key]
        public int BusinessEntityId { get; set; } 
        public BusinessEntity BusinessEntity { get; set; }
        public string NationalIdNumber { get; set; }
        public string LoginId { get; set; }
        public string JobTitle { get; set; }
        public DateTime BirthDate { get; set; }
        public char MaritalStatus { get; set; }
        public char Gender { get; set; }
        public DateTime HireDate { get; set; }
        public Boolean SalariedFlag { get; set; }
        public Int16 VacationHours { get; set; }
        public Int16 SickLeaveHours { get; set; }
        public Boolean CurrentFlag { get; set; }
        public Guid? RowGuid { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
    