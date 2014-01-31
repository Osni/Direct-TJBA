using Direct_TJBA.Models;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Direct_TJBA.DAO
{
    public class TipoReferenciaDAO
    {
        private ISession session;

        public TipoReferenciaDAO(ISession session)
        {
            this.session = session;
        }

        public void Adiciona(TipoReferencia tipo)
        {
            this.session.Save(tipo);
        }

        public void Deleta(TipoReferencia tipo)
        {
            this.session.Delete(tipo);
        }

        public void Atualiza(TipoReferencia tipo)
        {
            this.session.Merge(tipo);
        }

        public TipoReferencia BuscaPorId(int id)
        {
            return this.session.Get<TipoReferencia>(id);
        }

        public IList<TipoReferencia> Lista()
        {
            string hql = "from TipoReferencia t order by t.Id";
            IQuery query = this.session.CreateQuery(hql);
            return query.List<TipoReferencia>();
        }

        public IList<TipoReferencia> BuscaPorNome(string descricao)
        {
            string hql = "from TipoReferencia t where t.Descricao = :descricao";
            IQuery query = this.session.CreateQuery(hql);
            query.SetParameter("descricao", descricao);
            return query.List<TipoReferencia>();
        }
    }
}