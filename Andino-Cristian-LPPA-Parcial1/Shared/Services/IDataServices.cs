using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Andino_Cristian_LPPA_Parcial1.Shared.Services
{
    public interface IDataServices<T>
    {
        List<ValidationResult> ValidateModel(T model);
        List<T> Get(
            Expression<Func<T, bool>> whereExpression = null, //le paso una expresion where con los filtros, por default es null
            Func<IQueryable<T>, IOrderedQueryable<T>> orderFunction = null, // si quiero que venga ordenado por un criterio, por defaul es null
            string includeModels = ""); // le digo con que otro modelo esta incluido para nevegar a otros objetos y poder recuperar sus valores
        T GetById(int id);
        T Create(T entity);
        void Update(T entity);
        void Delete(T entity);
        void Delete(int id);
    }
}
