using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace STIVE_API.Helpers
{
    public static class PasswordHelper
    {

        public static bool CheckPasswordVerify(string password, string passwordVerify)
        {
            return password == passwordVerify;
        }

        
    }
}
