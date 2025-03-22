using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_System.Domain.Account
{
    public interface IAuthenticate
    {
        public string GenerateToken(int _id, string _email);
    }
}