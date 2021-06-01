using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.Validators
{
    public static class Validators
    {
        private static int legalAge = 16;
        public static bool IsLegalAge(DateTime dateTime) => (DateTime.Now.Year - dateTime.Year ) > legalAge;
        

        
    }
}
