/*
    Author      :   Aamir Parre
    Description :   This code is an advance level of Entity Framework Code First work flow,
                    a lecture Delivered on 24th November. The reason i wrote this code is to level up
				    the beginers who after writing a basic code think they have become ultima software 
				    developers. 
				    This advance level shows how to implement the Repository Pattern and save yourself 
				    to write the code bulky code for each entity in the system to achieve the CRUD operations. 
				    In summary, this pattern reduces the line of code, inreases the maintainablity and reuseability.

    Date		:	25th November, 2023
    Location	:	G - 11 / 4 Home, Islamabad
*/
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace EFCodeFirst.Repository
{
    public abstract class BaseRepository<TEntity> where TEntity : class
    {
        protected readonly DbContext Context;
        protected DbSet<TEntity> Entities => Context.Set<TEntity>();

        public BaseRepository(DbContext dbContext)
        {
            Context = dbContext;
        }
        public TEntity Create(TEntity entity)
        {
            Entities.Add(entity);
            return entity;
        }

        public TEntity Delete(TEntity entity)
        {
            Entities.Remove(entity);
            return entity;
        }

        public IQueryable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return Entities.Where(predicate);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return Entities.ToList();
        }

        public int SaveChanges()
        {
            return Context.SaveChanges();
        }

        public TEntity Update(TEntity entity)
        {
            Context.Entry(entity).CurrentValues.SetValues(entity);
            Context.Entry(entity).State = EntityState.Modified;
            return entity;
        }
    }
}