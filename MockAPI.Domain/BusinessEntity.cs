using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockAPI.Domain
{
    public class BusinessEntity
    {
        public int Id { get; set; }
        public int BusinessEntityId { get; set; }
        public string RowGuid { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
