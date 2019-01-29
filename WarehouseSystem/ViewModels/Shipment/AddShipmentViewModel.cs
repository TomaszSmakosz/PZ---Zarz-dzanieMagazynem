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
    //ViewModel do widoku AddShipment
    public class AddShipmentViewModel : Screen
    {
        public string ShippedItem { get; set; }
        public int ItemQuantity { get; set; }
        public string RecipientCompany { get; set; }
        public string CityTown { get; set; }
        public string PostalCode1 { get; set; }
        public string PostalCode2 { get; set; }
        public string StreetAddress { get; set; }
        public decimal Weight { get; set; }
        public string Description { get; set; }

        public void Add()
        {
            var newShipment = new ShipmentDTO();
            newShipment.ShippedItem = ShippedItem;
            newShipment.ItemQuantity = ItemQuantity;
            newShipment.RecipientCompany = RecipientCompany;
            newShipment.CityTown = CityTown;
            newShipment.PostalCode = string.Format("{0}-{1}", PostalCode1, PostalCode2);
            newShipment.StreetAddress = StreetAddress;
            newShipment.Weight = Weight;
            newShipment.Description = Description;
            ShipmentService.Add(newShipment);
            TryClose();
        }

        public void Close()
        {
            TryClose();
        }
    }
}