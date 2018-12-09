using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseSystem.Models
{
    [Table("Shipment")]
    public class Shipment
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string ShippedItem { get; set; }

        [Required]
        public int ItemQuantity { get; set; }

        [Required]
        public string RecipientCompany { get; set; }

        [Required]
        public string CityTown { get; set; }

        [Required]
        public int PostalCode { get; set; }

        [Required]
        public string StreetAddress { get; set; }

        public bool IsDisable { get; set; }
    }
}