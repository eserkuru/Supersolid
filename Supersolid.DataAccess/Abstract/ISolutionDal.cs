using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Core.DataAccess;
using Supersolid.Entities.Concrete;

namespace Supersolid.DataAccess.Abstract
{
    public interface ISolutionDal : IEntityRepository<Solution>
    {
        /* Custom Operations */
        Solution GetFull(Expression<Func<Solution, bool>> filter);
        IList<Solution> GetFullList(Expression<Func<Solution, bool>> filter = null);
    }
}
