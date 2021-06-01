using Andino_Cristian_LPPA_Parcial1.Shared.Models;
using Andino_Cristian_LPPA_Parcial1.Shared.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Andino_Cristian_LPPA_Parcial1.Domain
{
    public class AfiliadosBiz
    {

        public List<Afiliados> Listar()
        {
            var db = new BaseDataServices<Afiliados>();
            var lista = db.Get();
            return lista;
        }
        //ojo
        public void Editar(Afiliados model)
        {
            var db = new BaseDataServices<Afiliados>();
            db.Update(model);
        }

        public Afiliados Get(int id)
        {
            var db = new BaseDataServices<Afiliados>();
            return db.GetById(id);
        }

        public void Eliminar(Afiliados model)
        {
            var db = new BaseDataServices<Afiliados>();
            db.Delete(model.Id);
        }
    }
}