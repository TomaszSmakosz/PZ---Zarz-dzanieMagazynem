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

            db.SaveChanges();
        }
    }
}