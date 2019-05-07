using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;
using WarehouseSystem.DTO;
using WarehouseSystem.Service;

namespace WarehouseSystem.ViewModels.EventReadOnly
{
    public class EventReadOnlyGridViewModel : Screen
    {
        public List<EventDTO> EventsReadOnly { get; set; } = new List<EventDTO>();

        public EventReadOnlyGridViewModel()
        {
            Reload();
        }

        protected override void OnViewLoaded(object view)
        {
            base.OnViewLoaded(view);
        }

        public void Reload()
        {
            EventsReadOnly = EventService.GetAll();
            NotifyOfPropertyChange(() => EventsReadOnly);
        }

        public void LoadDetailsPage(EventDTO customEvent)
        {
            IWindowManager manager = new WindowManager();
            EventReadOnlyWindowViewModel details = new EventReadOnlyWindowViewModel(customEvent);
            manager.ShowDialog(details, null, null);
            Reload();
        }
    }
}