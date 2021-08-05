using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datas
{
    public class Utilidades
    {
        public static string BcryptPasswordHash(string data)
        {
            return BCrypt.Net.BCrypt.HashPassword(data);
        }

        public static bool BcryptPasswordVerify(string enterPassword, string userPassword)
        {
            return BCrypt.Net.BCrypt.Verify(enterPassword, userPassword);
        }
    }
}
