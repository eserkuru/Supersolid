using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Core.DataAccess.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Supersolid.DataAccess.Abstract;
using Supersolid.DataAccess.Concrete.EntityFramework.Contexts;
using Supersolid.Entities.Concrete;

namespace Supersolid.DataAccess.Concrete.EntityFramework.Dals
{
    public class EfSolutionDal : EfEntityRepositoryBase<Solution, SupersolidContext>, ISolutionDal
    {
        public Solution GetFull(Expression<Func<Solution, bool>> filter)
        {
            using (var context = new SupersolidContext())
            {
                return context.Set<Solution>()
                    .Include(sg => sg.SolutionGroup)
                    .Where(e => e.IsDeleted == false).SingleOrDefault(filter);
            }
        }

        public IList<Solution> GetFullList(Expression<Func<Solution, bool>> filter = null)
        {
            using (var context = new SupersolidContext())
            {
                return filter == null
                    ? context.Set<Solution>()
                        .Include(sg => sg.SolutionGroup)
                        .Where(e => e.IsDeleted == false).ToList()
                    : context.Set<Solution>().Where(e => e.IsDeleted == false).Where(filter).ToList();
            }
        }
    }
}
