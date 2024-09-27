using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class AuthService
    {
        public static bool Authentication(string username, string password)
        {
            var data = DataAccess.AuthData().Authentication(username, password);
            return data;
        }
    }
}
