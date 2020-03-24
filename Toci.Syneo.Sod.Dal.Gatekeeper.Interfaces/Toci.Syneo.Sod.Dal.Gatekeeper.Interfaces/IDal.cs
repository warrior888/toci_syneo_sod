using System;
using System.Linq;
using System.Linq.Expressions;

namespace Toci.Syneo.Sod.Dal.Gatekeeper.Interfaces
{
    public interface IDal<TModel>
    {
        IQueryable<TModel> Select(Expression<Func<TModel, IQueryable<TModel>>> Where); // todo expand, improve, v0.1

        TModel Insert(TModel model);

        //todo ud
    }
}