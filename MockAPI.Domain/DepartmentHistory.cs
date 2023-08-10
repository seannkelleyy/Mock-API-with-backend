﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockAPI.Domain
{
    public class DepartmentHistory
    {
        public int Id { get; set; }
        public int BusinessEntityId { get; set; }
        public int DepartmentId { get; set; }
        public int ShiftId { get; set; }
        public DateOnly StartDate { get; set; }
        public DateOnly EndDate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}