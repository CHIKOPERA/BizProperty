using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Common
{
    public abstract class Record 
    {
        public DateTime CreatedDateTime { get; set; }
        public string EmailAddress { get; set; }
        public string ContactNumber { get; set; }
        public string Fax { get; set; }

        public string StreetAddress { get; set; }
        public string Surburb { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
    }
}
