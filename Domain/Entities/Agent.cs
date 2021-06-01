using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Agent :PersonRecord
    {
        // A normal person should be able to list a propety 
        public int AgentId { get; set; }
        public Agency ParentAgency { get; set; }
    }
}
