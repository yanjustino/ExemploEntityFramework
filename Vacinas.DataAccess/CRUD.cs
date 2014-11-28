using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vacinas.DataModel;
using Vacinas.DataModel.Contracts;

namespace Vacinas.DataAccess
{
    public class CRUD<T>: ICRUD<T> where T: class
    {
        private DataContext BD;

        public CRUD()
        {
            BD = DataContext.Current;
        }

        public List<T> Listar()
        {
            return BD.Set<T>().ToList();
        }

        public T Buscar(int id)
        {
            return BD.Set<T>().Find(id);
        }

        public void Criar(T model)
        {
            BD.Set<T>().Add(model);
        }

        public void Excluir(int id)
        {
            var model = BD.Set<T>().Find(id);
            BD.Set<T>().Remove(model);
        }

        public void Alterar(T model)
        {
            BD.Entry<T>(model).State = System.Data.Entity.EntityState.Modified;
        }

        public void Salvar()
        {
            BD.SaveChanges();
        }

        public void Dispose()
        {
            BD.Dispose();
        }
    }
}
