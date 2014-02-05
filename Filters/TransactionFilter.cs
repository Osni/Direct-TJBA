using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Direct_TJBA.Filters
{
    public class TransactionFilter : ActionFilterAttribute
    {
        //
        // GET: /TransactionFilter/
        private ISession session;

        public TransactionFilter(ISession session)
        {
            this.session = session;
        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            this.session.BeginTransaction();
        }
        //public override void OnActionExecuted(ActionExecutedContext context)
        //{
        //    this.session.Transaction.Commit();
        //    this.session.Close();
        //}
        public override void OnResultExecuted(ResultExecutedContext context)
        {
            try
            {
                if (context.Exception == null)
                {
                    this.session.Transaction.Commit();
                }
                else
                {
                    this.session.Transaction.Rollback();
                }
            }
            catch (Exception)
            {
                
                throw;
            }

            this.session.Close();
        }
    }
}