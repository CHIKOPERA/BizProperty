using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public abstract class PersonRecord : Record
    {
        public PersonRecord()
        {
            Listings = new HashSet<Listing>();
        }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string  LastName { get; set; }
        public DateTime DOB { get; set; }
        public byte[] Photo { get; set; }
        public string PhotoPath { get; set; }
        public ICollection<Listing> Listings { get; set; }



    }
}
