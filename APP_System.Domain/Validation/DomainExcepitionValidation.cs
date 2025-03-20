using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_System.Domain.Validation
{
    public class DomainExcepitionValidation : Exception
    {
        public DomainExcepitionValidation(string error) : base(error)
        {
        }

        public static void When(bool hasError, string error)
        {
            if (hasError)
            {
                throw new DomainExcepitionValidation(error);
            }
        }
    }
}