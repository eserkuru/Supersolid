using System;
using System.Collections.Generic;
using Core.Utilities.Result;
using Supersolid.Entities.Concrete;

namespace Supersolid.Business.Abstract
{
    public interface ISolutionGroupService
    {
        IDataResult<SolutionGroup> GetById(Guid id);
        IDataResult<List<SolutionGroup>> GetList();
        IResult Add(SolutionGroup solutionGroup);
        IResult Update(SolutionGroup solutionGroup);
        IResult Delete(SolutionGroup solutionGroup);
        IResult Remove(SolutionGroup solutionGroup);
    }
}
