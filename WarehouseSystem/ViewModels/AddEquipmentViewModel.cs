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
    public class AddEquipmentViewModel : Screen
    {
        public string Type { get; set; }

        public string Mark { get; set; }

        public string Model { get; set; }

        public DateTime AddDate { get; set; } = DateTime.Now;

        public string Status { get; set; }

        public AddEquipmentViewModel()
        {
        }

        public void Add()
        {
            var newEquipment = new EquipmentDTO();
            newEquipment.Type = Type;
            newEquipment.Mark = Mark;
            newEquipment.Model = Model;
            newEquipment.AddDate = AddDate;
            newEquipment.Status = Status;
            EquipmentService.Add(newEquipment);
            TryClose();
        }

        public void Cancel()
        {
            TryClose();
        }
    }
}