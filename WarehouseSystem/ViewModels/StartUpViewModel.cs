using Caliburn.Micro;
using WarehouseSystem.Models;
using WarehouseSystem.ViewModels.Client;
using WarehouseSystem.ViewModels.Delivery;
using WarehouseSystem.ViewModels.Employee;
using WarehouseSystem.ViewModels.Equipment;
using WarehouseSystem.ViewModels.Inventory;
using WarehouseSystem.ViewModels.Order;
using WarehouseSystem.ViewModels.Return;
using WarehouseSystem.ViewModels.Shipment;
using WarehouseSystem.ViewModels.User;
using WarehouseSystem.ViewModels.Event;

namespace WarehouseSystem.ViewModels
{
    public class StartUpViewModel : Conductor<object>
    {
        private readonly WarehouseSystemContext context = new WarehouseSystemContext();

        public StartUpViewModel()
        {
        }

        protected override void OnViewLoaded(object view)
        {
            if (!context.Database.Exists())
            {
                IWindowManager manager = new WindowManager();
                DBInitializationViewModel dbInitializingView = new DBInitializationViewModel(context);
                manager.ShowDialog(dbInitializingView, null, null);
            }

            ActiveItem = new ClientGridViewModel();
        }

        //Loading pages methods
        public void LoadClientPage()
        {
            ActiveItem = new ClientGridViewModel();
        }

        public void LoadDeliveryPage()
        {
            ActiveItem = new DeliveryGridViewModel();
        }

        public void LoadEmployeePage()
        {
            ActiveItem = new EmployeeGridViewModel();
        }

        public void LoadEquipmentPage()
        {
            ActiveItem = new EquipmentGridViewModel();
        }

        public void LoadInventoryPage()
        {
            ActiveItem = new InventoryGridViewModel();
        }

        public void LoadOrderPage()
        {
            ActiveItem = new OrderGridViewModel();
        }

        public void LoadReturnPage()
        {
            ActiveItem = new ReturnGridViewModel();
        }

        public void LoadShipmentPage()
        {
            ActiveItem = new ShipmentGridViewModel();
        }

        public void LoadUserPage()
        {
            ActiveItem = new UserGridViewModel();
        }

        public void LoadEventPage()
        {
            ActiveItem = new EventGridViewModel();
        }
    }
}