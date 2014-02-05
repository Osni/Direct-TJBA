using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Direct_TJBA.Interfaces
{
    interface IDao<T>
    {
        void Adiciona(T obj);
        void Deleta(T obj);
        void Atualiza(T obj);
        T BuscaPorId(int id);
        IList<T> Lista();
        IList<T> BuscaPorNome(string descricao);
    }
}
