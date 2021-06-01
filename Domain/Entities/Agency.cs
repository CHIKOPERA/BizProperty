using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Agency: Record
    {
        public int AgencyId { get; set; }
        public string Name { get; set; }
        public List<Listing> Listings { get; set; }
        public List<Agent> Agents { get; set; }


    }
}
