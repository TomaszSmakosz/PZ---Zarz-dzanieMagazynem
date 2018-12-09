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
    public class ReturnService
    {
        public static List<ReturnDTO> GetAll()
        {
            using (WarehouseContext db = new WarehouseContext())
            {
                var result = db.Returns.Where(x => x.IsDisabled == false).Select(
                                   x => new ReturnDTO
                                   {
                                       Id = x.Id,
                                       Client = x.Client,
                                       Date = x.Date,
                                       Description = x.Description,
                                       Attachment = x.Attachment,
                                   }).ToList();
                return result;
            }
        }

        public static BindableCollection<ReturnDTO> GetAllBindableCollection()
        {
            using (WarehouseContext db = new WarehouseContext())
            {
                var result = new BindableCollection<ReturnDTO>(GetAll());
                return result;
            }
        }

        public static ReturnDTO GetById(int id)
        {
            using (WarehouseContext db = new WarehouseContext())
            {
                var result = db.Returns.Where(x => x.Id == id).Select(
                                    x => new ReturnDTO
                                    {
                                        Id = x.Id,
                                        Client = x.Client,
                                        Date = x.Date,
                                        Description = x.Description,
                                        Attachment = x.Attachment,
                                    }).FirstOrDefault();

                return result;
            }
        }

        public static string Add(ReturnDTO returnVar)
        {
            using (WarehouseContext db = new WarehouseContext())
            {
                string error = null;
                Return newReturn = new Return();
                newReturn.Id = returnVar.Id;
                newReturn.Client = returnVar.Client;
                newReturn.Date = returnVar.Date;
                newReturn.Description = returnVar.Description;
                newReturn.Attachment = returnVar.Attachment;

                var context = new ValidationContext(newReturn, null, null);
                var result = new List<ValidationResult>();
                Validator.TryValidateObject(newReturn, context, result, true);

                foreach (var x in result)
                {
                    error = error + x.ErrorMessage + "\n";
                }

                if (error == null)
                {
                    db.Returns.Add(newReturn);
                    db.SaveChanges();
                }
                return error;
            }
        }

        public static string Edit(ReturnDTO returnVar)
        {
            using (WarehouseContext db = new WarehouseContext())
            {
                string error = null;

                var toModify = db.Returns.Where(x => x.Id == returnVar.Id).FirstOrDefault();

                toModify.Id = returnVar.Id;
                toModify.Client = returnVar.Client;
                toModify.Date = returnVar.Date;
                toModify.Description = returnVar.Description;
                toModify.Attachment = returnVar.Attachment;

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

        public static void Delete(ReturnDTO returnVar)
        {
            using (WarehouseContext db = new WarehouseContext())
            {
                var toDelete = db.Returns.Where(x => x.Id == returnVar.Id).FirstOrDefault();
                toDelete.IsDisabled = true;

                db.SaveChanges();
            }
        }
    }
}