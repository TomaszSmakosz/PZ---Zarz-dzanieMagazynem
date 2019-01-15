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
    public class UserService
    {
        public static List<UserDTO> GetAll()
        {
            using (WarehouseContext db = new WarehouseContext())
            {
                var result = db.Users.Where(x => x.IsDisabled == false).Select(
                                   x => new UserDTO
                                   {
                                       FirstName = x.FirstName,
                                       LastName = x.LastName,
                                       Email = x.Email,
                                       PhoneNumber = x.PhoneNumber,
                                       BirthDate = x.BirthDate,
                                   }).ToList();
                return result;
            }
        }

        public static BindableCollection<UserDTO> GetAllBindableCollection()
        {
            using (WarehouseContext db = new WarehouseContext())
            {
                var result = new BindableCollection<UserDTO>(GetAll());
                return result;
            }
        }

        public static UserDTO GetById(int id)
        {
            using (WarehouseContext db = new WarehouseContext())
            {
                var result = db.Users.Where(x => x.Id == id).Select(
                                    x => new UserDTO
                                    {
                                        FirstName = x.FirstName,
                                        LastName = x.LastName,
                                        Email = x.Email,
                                        PhoneNumber = x.PhoneNumber,
                                        BirthDate = x.BirthDate,
                                    }).FirstOrDefault();

                return result;
            }
        }

        public static string Add(UserDTO user)
        {
            using (WarehouseContext db = new WarehouseContext())
            {
                string error = null;
                User newUser = new User();
                newUser.FirstName = user.FirstName;
                newUser.LastName = user.LastName;
                newUser.Email = user.Email;
                newUser.PhoneNumber = user.PhoneNumber;
                newUser.BirthDate = user.BirthDate;

                var context = new ValidationContext(newUser, null, null);
                var result = new List<ValidationResult>();
                Validator.TryValidateObject(newUser, context, result, true);

                foreach (var x in result)
                {
                    error = error + x.ErrorMessage + "\n";
                }

                if (error == null)
                {
                    db.Users.Add(newUser);
                    db.SaveChanges();
                }
                return error;
            }
        }

        public static string Edit(UserDTO user)
        {
            using (WarehouseContext db = new WarehouseContext())
            {
                string error = null;

                var toModify = db.Users.Where(x => x.Id == user.Id).FirstOrDefault();

                toModify.FirstName = user.FirstName;
                toModify.LastName = user.LastName;
                toModify.Email = user.Email;
                toModify.PhoneNumber = user.PhoneNumber;
                toModify.BirthDate = user.BirthDate;

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

        public static void Delete(UserDTO user)
        {
            using (WarehouseContext db = new WarehouseContext())
            {
                var toDelete = db.Users.Where(x => x.Id == user.Id).FirstOrDefault();
                toDelete.IsDisabled = true;

                db.SaveChanges();
            }
        }
    }
}