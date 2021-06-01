using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Exceptions
{
    class PropertyNotFoundException : Exception
    {
        public PropertyNotFoundException(string propertyListing,Exception ex)
            :base($"{propertyListing} has not been found",ex)
        {

        }
    }
}
