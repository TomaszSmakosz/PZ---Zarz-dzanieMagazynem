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
    public class EventService
    {
        public static List<EventDTO> GetAll()
        {
            using (WarehouseContext db = new WarehouseContext())
            {
                var result = db.Events.Where(x => x.IsDisabled == false).Select(
                                   x => new EventDTO
                                   {
                                       Id = x.Id,
                                       Name = x.Name,
                                       Description = x.Description,
                                       Executed = x.Executed,
                                       UserId = x.UserId,
                                   }).ToList();
                return result;
            }
        }

        public static BindableCollection<EventDTO> GetAllBindableCollection()
        {
            using (WarehouseContext db = new WarehouseContext())
            {
                var result = new BindableCollection<EventDTO>(GetAll());
                return result;
            }
        }

        public static EventDTO GetById(int id)
        {
            using (WarehouseContext db = new WarehouseContext())
            {
                var result = db.Events.Where(x => x.Id == id).Select(
                                    x => new EventDTO
                                    {
                                        Id = x.Id,
                                        Name = x.Name,
                                        Description = x.Description,
                                        Executed = x.Executed,
                                        UserId = x.UserId,
                                    }).FirstOrDefault();

                return result;
            }
        }

        public static string Add(EventDTO private event)

        {
            using (WarehouseContext db = new WarehouseContext())
            {
                string error = null;
                Event newEvent = new Event();

                newEvent.Id = event.Id;

        newEvent.Name = event.Name;

        newEvent.Description = event.Description;

        newEvent.Executed = event.Executed;

        newEvent.UserId = event.UserId;

        var context = private new ValidationContext(newEvent, null, null);

        private var result = new List<ValidationResult>();
        Validator.TryValidateObject(newEvent, context, result, true);

                foreach (var x in result)
                {
                    error = error + x.ErrorMessage + "\n";
                }

                if (error == null)
                {
                    db.Events.Add(newEvent);
                    db.SaveChanges();
                }

                return error;
            }
        }

        public static string Edit(EventDTO event)
{
    using (WarehouseContext db = new WarehouseContext())
    {
        string error = null;

        var toModify = db.Events.Where(x => x.Id == event.Id).FirstOrDefault();

        toModify.Id = event.Id;
        toModify.Name = event.Name;
        toModify.Description = event.Description;
        toModify.Executed = event.Executed;
        toModify.UserId = event.UserId;

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

public static void Delete(EventDTO event)
{
    using (WarehouseContext db = new WarehouseContext())
    {
        var toDelete = db.Events.Where(x => x.Id == event.Id).FirstOrDefault();
        toDelete.IsDisabled = true;

        db.SaveChanges();
    }
}
    }
}