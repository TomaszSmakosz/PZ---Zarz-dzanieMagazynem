using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseSystem.DTO;
using WarehouseSystem.Models;
using WarehouseSystem.Service;

namespace WarehouseSystem.ViewModels
{
    public class AddEmployeeViewModel : Screen
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime EmploymentDate { get; set; } = DateTime.Now;

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public string Workplace { get; set; }

        public bool IsDisabled { get; set; }

        public AddEmployeeViewModel()
        {
        }

        public void Add()
        {
            var newEmployee = new EmployeeDTO();
            newEmployee.FirstName = FirstName;
            newEmployee.LastName = LastName;
            newEmployee.EmploymentDate = EmploymentDate;
            newEmployee.Email = Email;
            newEmployee.PhoneNumber = PhoneNumber;
            newEmployee.Workplace = Workplace;
            EmployeeService.Add(newEmployee);
            TryClose();
        }

        public void Cancel()
        {
            TryClose();
        }
    }
}