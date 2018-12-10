﻿using Caliburn.Micro;
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
    public class EventHistoryService
    {
        public static List<EventHistoryDTO> GetAll()
        {
            using (WarehouseContext db = new WarehouseContext())
            {
                var result = db.EventHistories.Where(x => x.IsDisabled == false).Select(
                                   x => new EventHistoryDTO
                                   {
                                       Id = x.Id,
                                       EventId = x.EventId,
                                       StartDate = x.StartDate,
                                   }).ToList();
                return result;
            }
        }

        public static BindableCollection<EventHistoryDTO> GetAllBindableCollection()
        {
            using (WarehouseContext db = new WarehouseContext())
            {
                var result = new BindableCollection<EventHistoryDTO>(GetAll());
                return result;
            }
        }

        public static EventHistoryDTO GetById(int id)
        {
            using (WarehouseContext db = new WarehouseContext())
            {
                var result = db.EventHistories.Where(x => x.Id == id).Select(
                                    x => new EventHistoryDTO
                                    {
                                        Id = x.Id,
                                        EventId = x.EventId,
                                        StartDate = x.StartDate,
                                    }).FirstOrDefault();

                return result;
            }
        }

        public static string Add(EventHistoryDTO eventHistory)
        {
            using (WarehouseContext db = new WarehouseContext())
            {
                string error = null;
                EventHistory newEventHistory = new EventHistory();
                newEventHistory.Id = eventHistory.Id;
                newEventHistory.EventId = eventHistory.EventId;
                newEventHistory.StartDate = eventHistory.StartDate;

                var context = new ValidationContext(newEventHistory, null, null);
                var result = new List<ValidationResult>();
                Validator.TryValidateObject(newEventHistory, context, result, true);

                foreach (var x in result)
                {
                    error = error + x.ErrorMessage + "\n";
                }

                if (error == null)
                {
                    db.EventHistories.Add(newEventHistory);
                    db.SaveChanges();
                }
                return error;
            }
        }

        public static string Edit(EventHistoryDTO eventHistory)
        {
            using (WarehouseContext db = new WarehouseContext())
            {
                string error = null;

                var toModify = db.EventHistories.Where(x => x.Id == eventHistory.Id).FirstOrDefault();

                toModify.Id = eventHistory.Id;
                toModify.EventId = eventHistory.EventId;
                toModify.StartDate = eventHistory.StartDate;

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

        public static void Delete(EventHistoryDTO eventHistory)
        {
            using (WarehouseContext db = new WarehouseContext())
            {
                var toDelete = db.EventHistories.Where(x => x.Id == eventHistory.Id).FirstOrDefault();
                toDelete.IsDisabled = true;

                db.SaveChanges();
            }
        }
    }
}