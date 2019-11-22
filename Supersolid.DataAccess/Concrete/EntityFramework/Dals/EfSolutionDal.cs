using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Core.DataAccess.EntityFramework;
using Supersolid.DataAccess.Abstract;
using Supersolid.DataAccess.Concrete.EntityFramework.Contexts;
using Supersolid.Entities.Concrete;

namespace Supersolid.DataAccess.Concrete.EntityFramework.Dals
{
    public class EfSolutionDal : EfEntityRepositoryBase<Solution, SupersolidContext>, ISolutionDal
    {
    }
}
