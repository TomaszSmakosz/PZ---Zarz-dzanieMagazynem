using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security;
using System.Threading.Tasks;
using WarehouseSystem.DTO;
using WarehouseSystem.Service;
using WarehouseSystem.Authentication;

namespace WarehouseSystem.ViewModels
{
    public class LogInViewModel : Screen
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public LogInViewModel()
        {
        }

        public void LogIn(string username, string password)
        {
            if (Username == "admin" && Password == "admin")
            {
                Authentication.Authentication.Username = "admin";
                Authentication.Authentication.isLogged = true;
                Authentication.Authentication.isAdmin = true;
                TryClose();
            }
        }

        public void Close()
        {
            TryClose();
        }
    }
}