namespace WarehouseSystem.Model
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class WarehouseContext : DbContext
    {
        // Your context has been configured to use a 'Warehouse' connection string from your application's
        // configuration file (App.config or Web.config). By default, this connection string targets the
        // 'WarehouseSystem.Model.Warehouse' database on your LocalDb instance.
        //
        // If you wish to target a different database and/or database provider, modify the 'Warehouse'
        // connection string in the application configuration file.
        public WarehouseContext() : base()
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Delivery> Deliveries { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Equipment> Equipments { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<EventHistory> EventHistory { get; set; }
        public DbSet<Inventory> Inventory { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Return> Returns { get; set; }
        public DbSet<Shipment> Shipments { get; set; }
        public DbSet<User> Users { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}