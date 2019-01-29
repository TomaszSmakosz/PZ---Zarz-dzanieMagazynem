using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseSystem.DTO;
using WarehouseSystem.Service;

namespace WarehouseSystem.ViewModels
{
    public class AddUserViewModel : Screen
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime BirthDate { get; set; } = DateTime.Now;

        public AddUserViewModel()
        {
        }

        public void Add()
        {
            var newUser = new UserDTO();
            newUser.FirstName = FirstName;
            newUser.LastName = LastName;
            newUser.PhoneNumber = Phone;
            newUser.Email = Email;
            newUser.BirthDate = BirthDate;
            UserService.Add(newUser);
            TryClose();
        }

        public void Close()
        {
            TryClose();
        }
    }
}