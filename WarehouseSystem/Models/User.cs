using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseSystem.Models
{
    [Table("User")]
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = ("First name is required."))]
        public string FirstName { get; set; }

        [Required(ErrorMessage = ("Last name is required."))]
        public string LastName { get; set; }

        [Required(ErrorMessage = ("Birth date is required."))]
        public DateTime BirthDate { get; set; }

        [Required(ErrorMessage = ("Email is required."))]
        public string Email { get; set; }

        [Required(ErrorMessage = ("PhoneNumber number is required."))]
        public string PhoneNumber { get; set; }

        public bool IsDisabled { get; set; }
    }
}