using Direct_TJBA.Interfaces;
using Direct_TJBA.Models;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Direct_TJBA.DAO
{
    public class PontoDAO : IDao<Ponto>
    {
        private ISession session;

        public PontoDAO(ISession session)
        {
            this.session = session;
        }
        public void Adiciona(Ponto ponto)
        {
            this.session.Save(ponto);
        }

        public void Deleta(Ponto ponto)
        {
            this.session.Delete(ponto);
        }

        public void Atualiza(Ponto ponto)
        {
            this.session.Merge(ponto);
        }

        public Ponto BuscaPorId(int id)
        {
            return this.session.Get<Ponto>(id);
        }

        public IList<Ponto> Lista()
        {
            string hql = "from Ponto p order by p.Referencia.Id,p.Id";
            IQuery query = this.session.CreateQuery(hql);
            return query.List<Ponto>();
        }

        public IList<Ponto> BuscaPorNome(string descricao)
        {
            string hql = "from Ponto p where p.Descricao = :descricao";
            IQuery query = this.session.CreateQuery(hql);
            query.SetParameter("descricao", descricao);
            return query.List<Ponto>();
        }
    }
}