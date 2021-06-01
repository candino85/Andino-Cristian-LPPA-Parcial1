using Andino_Cristian_LPPA_Parcial1.Shared.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace Andino_Cristian_LPPA_Parcial1.Shared.Services
{
    public class BaseDataServices<T> : IDataServices<T> where T : IdentityBase, new()
    {
        protected Parcial1DbContext Db;

        public BaseDataServices()
        {
            this.Db = new Parcial1DbContext();
        }

        public void Delete(T entity)
        {
            Db.Set<T>().Remove(entity);
            Db.SaveChanges();
        }

        public void Delete(int id)
        {            
            Db.Set<T>().Remove(this.GetById(id));
            Db.SaveChanges();
        }

        public List<T> Get(Expression<Func<T, bool>> whereExpression = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderFunction = null, string includeModels = "")
        {

            IQueryable<T> query = Db.Set<T>();

            if (whereExpression != null)
                query = query.Where(whereExpression);
           
            var entity = includeModels.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            
            query = entity.Aggregate(query, (current, model) => current.Include(model));
            
            if (orderFunction != null)
                query = orderFunction(query);

            return query.ToList();
        }

        public T GetById(int id)
        {
            return Db.Set<T>().SingleOrDefault(o => o.Id == id);
        }

        public void Update(T entity)
        {
            Db.Entry(entity).State = EntityState.Modified;
            Db.SaveChanges();
        }

        public List<ValidationResult> ValidateModel(T model)
        {
            throw new NotImplementedException();
        }
    }
}