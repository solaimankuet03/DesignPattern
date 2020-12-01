﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RepositoryDesignPatternUsingEFinMVC.DAL;
using System.Data.Entity;

namespace RepositoryDesignPatternUsingEFinMVC.GenericRepository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        public EmployeeDBContext _context = null;
        public DbSet<T> table = null;

        public GenericRepository()
        {
            _context = new EmployeeDBContext();
            table = _context.Set<T>();
        }

        public GenericRepository(EmployeeDBContext context)
        {
            this._context = context;
            this.table = _context.Set<T>();
        }       

        public IEnumerable<T> GetAll()
        {
            return table.ToList();
        }

        public T GetById(object id)
        {
            return table.Find(id);
        }

        public void Insert(T obj)
        {
            table.Add(obj);
        }

        public void Update(T obj)
        {
            table.Attach(obj);
            _context.Entry(obj).State = EntityState.Modified
        }

        public void Delete(object id)
        {
            T existing = table.Find(id);

            table.Remove(existing);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}