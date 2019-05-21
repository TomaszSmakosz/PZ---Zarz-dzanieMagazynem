using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseSystem.DTO;
using WarehouseSystem.Service;

namespace WarehouseSystem.ViewModels.User
{
    public class LogInViewModel : Screen
    {
        public LogInViewModel()
        {
        }

        public void Close()
        {
            TryClose();
        }
    }
}