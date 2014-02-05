using Direct_TJBA.Interfaces;
using Direct_TJBA.Models;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Direct_TJBA.DAO
{
    public class ReferenciaDAO : IDao<Referencia>
    {
        private ISession session;

        public ReferenciaDAO(ISession session)
        {
            this.session = session;
        }
        public void Adiciona(Referencia referencia)
        {
            this.session.Save(referencia);
        }

        public void Deleta(Referencia referencia)
        {
            this.session.Delete(referencia);
        }

        public void Atualiza(Referencia referencia)
        {
            this.session.Merge(referencia);
        }

        public Referencia BuscaPorId(int id)
        {
            return this.session.Get<Referencia>(id);
        }

        public IList<Referencia> Lista()
        {
            string hql = "from Referencia r order by r.Id";
            IQuery query = this.session.CreateQuery(hql);
            return query.List<Referencia>();
        }

        public IList<Referencia> BuscaPorNome(string descricao)
        {
            string hql = "from Referencia r where r.Descricao = :descricao";
            IQuery query = this.session.CreateQuery(hql);
            query.SetParameter("descricao", descricao);
            return query.List<Referencia>();
        }
    }
}