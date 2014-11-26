using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vacinas
{
    /// <summary>
    /// Classe genérica para manipular o banco
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class CRUD<T>: IDisposable where T: class
    {
        private BancoDados BD = new BancoDados();

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
