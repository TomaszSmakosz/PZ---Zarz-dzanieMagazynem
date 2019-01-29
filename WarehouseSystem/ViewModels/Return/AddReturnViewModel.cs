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
    public class AddReturnViewModel : Screen
    {
        public DateTime DateOfAddition { get; set; } = DateTime.Now;
        public string Client { get; set; }
        public string Description { get; set; }
        public string Attachment { get; set; }

        public void AddAttachment()
        {
        }

        public void Add()
        {
            var newReturn = new ReturnDTO();
            newReturn.Date = DateOfAddition;
            newReturn.Client = Client;
            newReturn.Description = Description;
            newReturn.Attachment = Attachment;
            ReturnService.Add(newReturn);
        }

        public void Close()
        {
            TryClose();
        }
    }
}