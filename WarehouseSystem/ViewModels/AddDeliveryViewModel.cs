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
    //ViewModel do widoku AddDelivery
    internal class AddDeliveryViewModel : Screen
    {
        public string DeliveredItem { get; set; }
        public int ItemQuantity { get; set; }
        public string RecipientCompany { get; set; }
        public string CityTown { get; set; }
        public string PostalCode1 { get; set; }
        public string PostalCode2 { get; set; }
        public string StreetAddress { get; set; }
        public int Weight { get; set; }
        public string Description { get; set; }

        public AddDeliveryViewModel()
        {
        }

        public void Add()
        {
            var newDelivery = new DeliveryDTO();
            newDelivery.DeliveredItem = DeliveredItem;
            newDelivery.ItemQuantity = ItemQuantity;
            newDelivery.RecipientCompany = RecipientCompany;
            newDelivery.CityTown = CityTown;
            newDelivery.PostalCode = string.Format("{0}-{1}", PostalCode1, PostalCode2);
            newDelivery.StreetAddress = StreetAddress;
            newDelivery.Weight = Weight;
            newDelivery.Description = Description;
            DeliveryService.Add(newDelivery);
            TryClose();
        }

        public void Close()
        {
            TryClose();
        }
    }
}