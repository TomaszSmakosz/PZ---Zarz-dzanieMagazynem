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
    public class AddInventoryViewModel : Screen
    {
        public string ItemFrom { get; set; }
        public string ItemTo { get; set; }
        public DateTime DateOfArrival { get; set; } = DateTime.Now;
        public DateTime DateToSend { get; set; } = DateTime.Now;
        public int Weight { get; set; }
        public string Status { get; set; }
        public string Description { get; set; }

        public void Add()
        {
            var newInventory = new InventoryDTO();
            newInventory.ItemFrom = ItemFrom;
            newInventory.ItemTo = ItemTo;
            newInventory.DateOfArrival = DateOfArrival;
            newInventory.DateToSend = DateToSend;
            newInventory.Weight = Weight;
            newInventory.Status = Status;
            newInventory.Description = Description;
            InventoryService.Add(newInventory);
            TryClose();
        }

        public void Close()
        {
            TryClose();
        }
    }
}