using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Toci.Syneo.Sod.Dal.Gatekeeper.Interfaces;

namespace Toci.Syneo.Sod.Dal.Gatekeeper
{
    public class DalBase<TModel> : IDal<TModel>
    {
        public IQueryable<TModel> Select(Expression<Func<TModel, IQueryable<TModel>>> Where)
        {
            throw new NotImplementedException();
        }

        public TModel Insert(TModel model)
        {
            throw new NotImplementedException();
        }
    }
}
