using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueTracker.Data
{
    public class Repository<T> where T : class
    {
        IssueTrackerContext ctx;

        public Repository(IssueTrackerContext ctx)
        {
            this.ctx = ctx;
        }

        public void Create(T entity)
        {
            ctx.Set<T>().Add(entity);
            ctx.SaveChanges();
        }

        public T FindById(string id)
        {
            return null;
        }
    }
}
