﻿using System;
using Contrucks.Repository.Infrastructure;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contrucks.Repository.Infrastructure
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        private ConTruckContext dataContext;
        private readonly IDbSet<T> dbset;
        protected RepositoryBase(IDatabaseFactory databaseFactory)
        {
            DatabaseFactory = databaseFactory;
            dbset = DataContext.Set<T>();
        }
        protected IDatabaseFactory DatabaseFactory
        {
            get;
            private set;
        }
        protected ConTruckContext DataContext
        {
            get { return dataContext ?? (dataContext = DatabaseFactory.Get()); }
        }
        public virtual void Add(T entity)
        {
            dbset.Add(entity);
        }
        public virtual void Update(T entity)
        {
            dbset.Attach(entity);
            dataContext.Entry(entity).State = EntityState.Modified;
        }
        public virtual void Delete(T entity)
        {
            dbset.Remove(entity);
        }


        public virtual IEnumerable<T> GetAll()
        {
            return dbset.ToList();
        }

    }
}
