using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vacinas.DataModel.Contracts
{
    public interface ICRUD<T> : IDisposable where T: class
    {
        List<T> Listar();
        T Buscar(int id);
        void Criar(T model);
        void Excluir(int id);
        void Alterar(T model);
        void Salvar();
    }
}
