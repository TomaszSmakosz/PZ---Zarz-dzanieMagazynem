using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseSystem.Authentication
{
    public class Authentication
    {
        public static string Username { get; set; }
        public static bool isLogged { get; set; }
        public static bool isAdmin { get; set; }

        public Authentication()
        {
            Username = string.Empty;
            isLogged = false;
            isAdmin = false;
        }
    }
}