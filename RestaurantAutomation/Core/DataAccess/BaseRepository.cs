﻿using Microsoft.EntityFrameworkCore;
using RestaurantAutomation.Core.Model;
using RestaurantAutomation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantAutomation.Core.DataAccess
{
    public abstract class BaseRepository<T> : IBaseRepository<T> where T : class, IModel, new()
    {
        public virtual List<T> GetAll()
        {
            using (var context = new SimpleDbContext())
            {
                return context.Set<T>().ToList();
            }
        }
        public virtual T GetById(int id)
        {
            using (var context = new SimpleDbContext())
            {
                return context.Set<T>().SingleOrDefault(u => u.Id == id);
            }
        }
        public virtual bool Add(T model)
        {
            using (var context = new SimpleDbContext())
            {
                var addedModel = context.Entry(model);
                addedModel.State = EntityState.Added;
                context.SaveChanges();
                return true;
            }
        }
        public virtual bool Update(T model)
        {
            using (var context = new SimpleDbContext())
            {
                var updatedModel = context.Update(model);
                updatedModel.State = EntityState.Modified;
                context.SaveChanges();
                return true;
            }
        }
        public virtual bool DeleteById(int id)
        {
            var model = this.GetById(id);
            using (var context = new SimpleDbContext())
            {
                var deletedModel = context.Entry(model);
                deletedModel.State = EntityState.Deleted;
                context.SaveChanges();
                return true;
            }
        }
    }
}
