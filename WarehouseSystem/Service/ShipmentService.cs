using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseSystem.DTO;
using WarehouseSystem.Models;

namespace WarehouseSystem.Service
{
    public class ShipmentService
    {
        public static List<ShipmentDTO> GetAll()
        {
            using (WarehouseContext db = new WarehouseContext())
            {
                var result = db.Shipments.Where(x => x.IsDisabled == false).Select(
                                   x => new ShipmentDTO
                                   {
                                       Id = x.Id,
                                       ShippedItem = x.ShippedItem,
                                       ItemQuantity = x.ItemQuantity,
                                       RecipientCompany = x.RecipientCompany,
                                       PostalCode = x.PostalCode,
                                       CityTown = x.CityTown,
                                       StreetAddress = x.StreetAddress,
                                   }).ToList();
                return result;
            }
        }

        public static BindableCollection<ShipmentDTO> GetAllBindableCollection()
        {
            using (WarehouseContext db = new WarehouseContext())
            {
                var result = new BindableCollection<ShipmentDTO>(GetAll());
                return result;
            }
        }

        public static ShipmentDTO GetById(int id)
        {
            using (WarehouseContext db = new WarehouseContext())
            {
                var result = db.Shipments.Where(x => x.Id == id).Select(
                                    x => new ShipmentDTO
                                    {
                                        Id = x.Id,
                                        ShippedItem = x.ShippedItem,
                                        ItemQuantity = x.ItemQuantity,
                                        RecipientCompany = x.RecipientCompany,
                                        PostalCode = x.PostalCode,
                                        CityTown = x.CityTown,
                                        StreetAddress = x.StreetAddress,
                                    }).FirstOrDefault();

                return result;
            }
        }

        public static string Add(ShipmentDTO shipment)
        {
            using (WarehouseContext db = new WarehouseContext())
            {
                string error = null;
                Shipment newShipment = new Shipment();
                newShipment.Id = shipment.Id;
                newShipment.ShippedItem = shipment.ShippedItem;
                newShipment.ItemQuantity = shipment.ItemQuantity;
                newShipment.RecipientCompany = shipment.RecipientCompany;
                newShipment.PostalCode = shipment.PostalCode;
                newShipment.CityTown = shipment.CityTown;
                newShipment.StreetAddress = shipment.StreetAddress;

                var context = new ValidationContext(newShipment, null, null);
                var result = new List<ValidationResult>();
                Validator.TryValidateObject(newShipment, context, result, true);

                foreach (var x in result)
                {
                    error = error + x.ErrorMessage + "\n";
                }

                if (error == null)
                {
                    db.Shipments.Add(newShipment);
                    db.SaveChanges();
                }
                return error;
            }
        }

        public static string Edit(ShipmentDTO shipment)
        {
            using (WarehouseContext db = new WarehouseContext())
            {
                string error = null;

                var toModify = db.Shipments.Where(x => x.Id == shipment.Id).FirstOrDefault();

                toModify.Id = shipment.Id;
                toModify.ShippedItem = shipment.ShippedItem;
                toModify.RecipientCompany = shipment.RecipientCompany;
                toModify.ItemQuantity = shipment.ItemQuantity;
                toModify.PostalCode = shipment.PostalCode;
                toModify.CityTown = shipment.CityTown;
                toModify.StreetAddress = shipment.StreetAddress;

                var context = new ValidationContext(toModify, null, null);
                var result = new List<ValidationResult>();
                Validator.TryValidateObject(toModify, context, result, true);

                foreach (var x in result)
                {
                    error = error + x.ErrorMessage + "\n";
                }

                if (error == null)
                {
                    db.SaveChanges();
                }
                return error;
            }
        }

        public static void Delete(ShipmentDTO shipment)
        {
            using (WarehouseContext db = new WarehouseContext())
            {
                var toDelete = db.Shipments.Where(x => x.Id == shipment.Id).FirstOrDefault();
                toDelete.IsDisabled = true;

                db.SaveChanges();
            }
        }
    }
}