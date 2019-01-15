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

        /* private string companyName;
         private string city;
         private string postalCode;
         private string postalCode2;
         private string streetAdress;
         private string email;
         private string phone;

         public string CompanyName
         {
             get { return companyName; }
             set { companyName = value; }
         }

         public string CityTown
         {
             get { return city; }
             set { city = value; }
         }

         public string PostalCode1
         {
             get { return postalCode; }
             set { postalCode = value; }
         }

         public string PostalCode2
         {
             get { return postalCode2; }
             set { postalCode2 = value; }
         }

         public string StreetAddress
         {
             get { return streetAdress; }
             set { streetAdress = value; }
         }

         public string Email
         {
             get { return email; }
             set { email = value; }
         }

         public string Phone
         {
             get { return phone; }
             set { phone = value; }
         }

         private string error;

         public string Error
         {
             get { return error; }
             set
             {
                 error = value;
                 NotifyOfPropertyChange(() => Error);
             }
         }

         public void Add()
         {
             string x = ClientService.Add(companyName, city, postalCode, postalCode2, email, phone);
             if (x == null)
                 TryClose();
             else
                 Error = x;
         }

         public void Close()
         {
             TryClose();
         }
     } */
    }