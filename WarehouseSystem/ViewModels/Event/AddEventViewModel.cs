using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;
using WarehouseSystem.DTO;
using WarehouseSystem.Service;

namespace WarehouseSystem.ViewModels
{
    public class AddEventViewModel : Screen
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Executed { get; set; }
        public int UserId { get; set; }
        private bool IsEdit { get; set; }
        public string ButtonLabel { get; set; }
        private EventDTO toEdit { get; set; }

        public AddEventViewModel(EventDTO customEvent)
        {
            IsEdit = true;
            ButtonLabel = "Edit";
            this.toEdit = customEvent;
            Name = customEvent.Name;
            Description = customEvent.Description;
            Executed = customEvent.Executed;
            UserId = customEvent.UserId;

            NotifyOfPropertyChange(() => Name);
            NotifyOfPropertyChange(() => Description);
            NotifyOfPropertyChange(() => Executed);
            NotifyOfPropertyChange(() => UserId);
            NotifyOfPropertyChange(() => Description);
        }

        public AddEventViewModel()
        {
            IsEdit = false;
            ButtonLabel = "Add";
        }

        public void Add()
        {
            if (IsEdit == true)
            {
                toEdit.Name = Name;
                toEdit.Description = Description;
                toEdit.UserId = UserId;
                toEdit.Executed = Executed;
                EventService.Edit(toEdit);
            }
            else
            {
                var newEvent = new EventDTO();
                newEvent.Name = Name;
                newEvent.Description = Description;
                newEvent.UserId = UserId;
                newEvent.Executed = Executed;
                EventService.Add(newEvent);
            }
            TryClose();
        }

        public void Close()
        {
            TryClose();
        }
    }
}