﻿using Core.DataAccess.EntityFramework;
using Supersolid.DataAccess.Abstract;
using Supersolid.DataAccess.Concrete.EntityFramework.Contexts;
using Supersolid.Entities.Concrete;

namespace Supersolid.DataAccess.Concrete.EntityFramework.Dals
{
    public class EfSolutionGroupDal : EfEntityRepositoryBase<SolutionGroup, SupersolidContext>, ISolutionGroupDal
    {
    }
}
