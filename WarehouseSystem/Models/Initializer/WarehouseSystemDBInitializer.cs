using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseSystem.Models.Initializer
{
    internal class WarehouseSystemDBInitializer
    {
        public static void Seed(WarehouseSystemContext db)
        {
            IList<Client> Clients = new List<Client>();
            Clients.Add(new Client() { Id = 1, CompanyName = "Alfa", PostalCode = "16-010", Address = "TestAddress1", Email = "testEmail@test.com", PhoneNumber = "123456789" });
            Clients.Add(new Client() { Id = 2, CompanyName = "Beta", PostalCode = "16-011", Address = "TestAddress2", Email = "testEmail2@test.com", PhoneNumber = "6789" });
            Clients.Add(new Client() { Id = 3, CompanyName = "Gamma", PostalCode = "16-012", Address = "TestAddress3", Email = "testEmail3@test.com", PhoneNumber = "123456" });
            Clients.Add(new Client() { Id = 4, CompanyName = "Delta", PostalCode = "16-013", Address = "TestAddress4", Email = "testEmail4@test.com", PhoneNumber = "1234589" });

            foreach (var item in Clients)
                db.Clients.Add(item);

            IList<Delivery> Deliveries = new List<Delivery>();
            Deliveries.Add(new Delivery() { Id = 1, RecipientCompany = "Alfa", PostalCode = "16-010", CityTown = "TestAddress1", DeliveredItem = "item1", ItemQuantity = 1, Description = "desc1", StreetAddress = "addr1", Weight = 15 });
            Deliveries.Add(new Delivery() { Id = 2, RecipientCompany = "Beta", PostalCode = "16-010", CityTown = "TestAddress1", DeliveredItem = "item1", ItemQuantity = 1, Description = "desc1", StreetAddress = "addr1", Weight = 15 });
            Deliveries.Add(new Delivery() { Id = 3, RecipientCompany = "Gamma", PostalCode = "16-010", CityTown = "TestAddress1", DeliveredItem = "item1", ItemQuantity = 1, Description = "desc1", StreetAddress = "addr1", Weight = 15 });
            Deliveries.Add(new Delivery() { Id = 4, RecipientCompany = "Delta", PostalCode = "16-010", CityTown = "TestAddress1", DeliveredItem = "item1", ItemQuantity = 1, Description = "desc1", StreetAddress = "addr1", Weight = 15 });

            foreach (var item in Deliveries)
                db.Deliveries.Add(item);

            IList<Employee> Employees = new List<Employee>();
            Employees.Add(new Employee() { Id = 1, FirstName = "Alfa", LastName = "Alfa", Email = "test1@test.com", PhoneNumber = "1313123", EmploymentDate = new DateTime(2017, 2, 14), Workplace = "workplace1" });
            Employees.Add(new Employee() { Id = 2, FirstName = "Beta", LastName = "Beta", Email = "test2@test.com", PhoneNumber = "1323123", EmploymentDate = new DateTime(2017, 2, 11), Workplace = "workplace2" });
            Employees.Add(new Employee() { Id = 3, FirstName = "Gamma", LastName = "Gamma", Email = "test3@test.com", PhoneNumber = "133123", EmploymentDate = new DateTime(2017, 2, 13), Workplace = "workplace3" });
            Employees.Add(new Employee() { Id = 4, FirstName = "Delta", LastName = "Delta", Email = "test4@test.com", PhoneNumber = "13223", EmploymentDate = new DateTime(2017, 2, 12), Workplace = "workplace4" });

            foreach (var item in Employees)
                db.Employees.Add(item);

            IList<Equipment> Equipments = new List<Equipment>();
            Equipments.Add(new Equipment() { Id = 1, Type = "Alfa", Mark = "Test", Model = "Test", AddDate = new DateTime(2017, 3, 3), Status = "Test" });
            Equipments.Add(new Equipment() { Id = 2, Type = "Beta", Mark = "Test2", Model = "Test2", AddDate = new DateTime(2017, 4, 9), Status = "Test2" });
            Equipments.Add(new Equipment() { Id = 3, Type = "Gamma", Mark = "Test3", Model = "Test3", AddDate = new DateTime(2017, 1, 11), Status = "Test3" });
            Equipments.Add(new Equipment() { Id = 4, Type = "Delta", Mark = "Test4", Model = "Test4", AddDate = new DateTime(2017, 7, 12), Status = "Test4" });

            foreach (var item in Equipments)
                db.Equipments.Add(item);

            IList<Event> Events = new List<Event>();
            Events.Add(new Event() { Id = 1, Name = "Test", Description = "Test", Executed = true, UserId = 1 });
            Events.Add(new Event() { Id = 2, Name = "Test2", Description = "Test2", Executed = true, UserId = 2 });
            Events.Add(new Event() { Id = 3, Name = "Test3", Description = "Test3", Executed = false, UserId = 3 });
            Events.Add(new Event() { Id = 4, Name = "Test4", Description = "Test4", Executed = false, UserId = 4 });

            foreach (var item in Events)
                db.Events.Add(item);

            IList<EventHistory> EventHistory = new List<EventHistory>();
            EventHistory.Add(new EventHistory() { Id = 1, EventId = 1, StartDate = new DateTime(2017, 2, 14) });
            EventHistory.Add(new EventHistory() { Id = 2, EventId = 2, StartDate = new DateTime(2017, 6, 14) });
            EventHistory.Add(new EventHistory() { Id = 3, EventId = 3, StartDate = new DateTime(2017, 3, 14) });
            EventHistory.Add(new EventHistory() { Id = 4, EventId = 4, StartDate = new DateTime(2017, 2, 16) });

            foreach (var item in EventHistory)
                db.EventHistory.Add(item);

            IList<Inventory> Inventory = new List<Inventory>();
            Inventory.Add(new Inventory() { Id = 1, ItemFrom = "Test", ItemTo = "Test", DateOfArrival = new DateTime(2017, 1, 3), DateToSend = new DateTime(2017, 2, 3), Weight = 3, Status = "Test", Description = "Test" });
            Inventory.Add(new Inventory() { Id = 2, ItemFrom = "Test2", ItemTo = "Test2", DateOfArrival = new DateTime(2017, 1, 4), DateToSend = new DateTime(2017, 2, 4), Weight = 1, Status = "Test2", Description = "Test2" });
            Inventory.Add(new Inventory() { Id = 3, ItemFrom = "Test3", ItemTo = "Test3", DateOfArrival = new DateTime(2017, 1, 5), DateToSend = new DateTime(2017, 2, 5), Weight = 7, Status = "Test3", Description = "Test3" });
            Inventory.Add(new Inventory() { Id = 4, ItemFrom = "Test4", ItemTo = "Test4", DateOfArrival = new DateTime(2017, 1, 6), DateToSend = new DateTime(2017, 2, 6), Weight = 5, Status = "Test4", Description = "Test4" });

            foreach (var item in Inventory)
                db.Inventory.Add(item);

            IList<Order> Orders = new List<Order>();
            Orders.Add(new Order() { Id = 1, OrderItem = "Test", ItemQuantity = 1, RecipientCompany = "Test", CityTown = "Test", PostalCode = "13-011", StreetAddress = "Test" });
            Orders.Add(new Order() { Id = 2, OrderItem = "Test2", ItemQuantity = 23, RecipientCompany = "Test2", CityTown = "Test2", PostalCode = "13-101", StreetAddress = "Test2" });
            Orders.Add(new Order() { Id = 3, OrderItem = "Test3", ItemQuantity = 2, RecipientCompany = "Test3", CityTown = "Test3", PostalCode = "13-031", StreetAddress = "Test3" });
            Orders.Add(new Order() { Id = 4, OrderItem = "Test4", ItemQuantity = 15, RecipientCompany = "Test4", CityTown = "Test4", PostalCode = "13-001", StreetAddress = "Test4" });

            foreach (var item in Orders)
                db.Orders.Add(item);

            IList<Return> Returns = new List<Return>();
            Returns.Add(new Return() { Id = 1, Client = "Test", Date = new DateTime(2017, 4, 6), Description = "Test", Attachment = "Test" });
            Returns.Add(new Return() { Id = 2, Client = "Test2", Date = new DateTime(2017, 4, 7), Description = "Test2", Attachment = "Test2" });
            Returns.Add(new Return() { Id = 3, Client = "Test3", Date = new DateTime(2017, 4, 8), Description = "Test3", Attachment = "Test3" });
            Returns.Add(new Return() { Id = 4, Client = "Test4", Date = new DateTime(2017, 4, 9), Description = "Test4", Attachment = "Test4" });

            foreach (var item in Returns)
                db.Returns.Add(item);

            IList<Shipment> Shipments = new List<Shipment>();
            Shipments.Add(new Shipment() { Id = 1, ShippedItem = "Test", ItemQuantity = 1, RecipientCompany = "Test", CityTown = "Test", PostalCode = "13-097", StreetAddress = "Test", Weight = 4, Description = "Test" });
            Shipments.Add(new Shipment() { Id = 2, ShippedItem = "Test2", ItemQuantity = 12, RecipientCompany = "Test2", CityTown = "Test2", PostalCode = "12-197", StreetAddress = "Test2", Weight = 44, Description = "Test2" });
            Shipments.Add(new Shipment() { Id = 3, ShippedItem = "Test3", ItemQuantity = 6, RecipientCompany = "Test3", CityTown = "Test3", PostalCode = "15-297", StreetAddress = "Test3", Weight = 2, Description = "Test3" });
            Shipments.Add(new Shipment() { Id = 4, ShippedItem = "Test4", ItemQuantity = 8, RecipientCompany = "Test4", CityTown = "Test4", PostalCode = "13-297", StreetAddress = "Test4", Weight = 12, Description = "Test4" });

            foreach (var item in Shipments)
                db.Shipments.Add(item);

            IList<User> Users = new List<User>();
            Users.Add(new User() { Id = 1, FirstName = "Test", LastName = "Test", BirthDate = new DateTime(1999, 1, 13), Email = "test@gmail.com", PhoneNumber = "654321123" });
            Users.Add(new User() { Id = 2, FirstName = "Test2", LastName = "Test2", BirthDate = new DateTime(1999, 2, 13), Email = "test2@gmail.com", PhoneNumber = "654311123" });
            Users.Add(new User() { Id = 3, FirstName = "Test3", LastName = "Test3", BirthDate = new DateTime(1999, 6, 13), Email = "test3@gmail.com", PhoneNumber = "654331123" });
            Users.Add(new User() { Id = 4, FirstName = "Test4", LastName = "Test4", BirthDate = new DateTime(1999, 5, 13), Email = "test4@gmail.com", PhoneNumber = "654341123" });

            foreach (var item in Users)
                db.Users.Add(item);

            db.SaveChanges();
        }
    }
}