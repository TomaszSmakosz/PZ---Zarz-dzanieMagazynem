using WarehouseSystem.Service;
using WarehouseSystem.DTO;
using WarehouseSystem.Models;
using WarehouseSystem.Views;
using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseSystem.ViewModels
{
    //ViewModel do widoku AddClientView
    public class AddClientViewModel : Screen
    {
        public string CompanyName { get; set; }
        public string PostalCode1 { get; set; }
        public string PostalCode2 { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public AddClientViewModel()
        {
        }

        public void Add()
        {
            var newClient = new ClientDTO();
            newClient.CompanyName = CompanyName;
            newClient.PostalCode = string.Format("{0}-{1}", PostalCode1, PostalCode2);
            newClient.Address = Address;
            newClient.Email = Email;
            newClient.PhoneNumber = PhoneNumber;
            ClientService.Add(newClient);
            TryClose();
        }

        public void Close()
        {
            TryClose();
        }
    }
}