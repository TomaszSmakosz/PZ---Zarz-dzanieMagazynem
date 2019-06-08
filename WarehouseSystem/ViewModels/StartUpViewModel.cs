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
using WarehouseSystem.ViewModels.EventReadOnly;

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

            ActiveItem = new EventReadOnlyGridViewModel();
        }

        //Loading pages methods
        public void LoadClientPage()
        {
            if (Authentication.Authentication.isAdmin) ActiveItem = new ClientGridViewModel();
        }

        public void LoadDeliveryPage()
        {
            if (Authentication.Authentication.isAdmin) ActiveItem = new DeliveryGridViewModel();
        }

        public void LoadEmployeePage()
        {
            if (Authentication.Authentication.isAdmin) ActiveItem = new EmployeeGridViewModel();
        }

        public void LoadEquipmentPage()
        {
            if (Authentication.Authentication.isAdmin) ActiveItem = new EquipmentGridViewModel();
        }

        public void LoadInventoryPage()
        {
            if (Authentication.Authentication.isAdmin) ActiveItem = new InventoryGridViewModel();
        }

        public void LoadOrderPage()
        {
            if (Authentication.Authentication.isAdmin) ActiveItem = new OrderGridViewModel();
        }

        public void LoadReturnPage()
        {
            if (Authentication.Authentication.isAdmin) ActiveItem = new ReturnGridViewModel();
        }

        public void LoadShipmentPage()
        {
            if (Authentication.Authentication.isAdmin) ActiveItem = new ShipmentGridViewModel();
        }

        public void LoadUserPage()
        {
            if (Authentication.Authentication.isAdmin) ActiveItem = new UserGridViewModel();
        }

        public void LoadEventPage()
        {
            if (Authentication.Authentication.isAdmin) ActiveItem = new EventGridViewModel();
        }

        public void LoadEventReadOnlyPage()
        {
            ActiveItem = new EventReadOnlyGridViewModel();
        }

        public void LoadLogInPage()
        {
            if (!Authentication.Authentication.isAdmin) ActiveItem = new LogInViewModel();
        }
    }
}