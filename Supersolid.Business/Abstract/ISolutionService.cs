using System;
using System.Collections.Generic;
using Core.Utilities.Result;
using Supersolid.Entities.Concrete;

namespace Supersolid.Business.Abstract
{
    public interface ISolutionService
    {
        IDataResult<Solution> GetById(Guid id);
        IDataResult<List<Solution>> GetList();
        IResult Add(Solution solution);
        IResult Update(Solution solution);
        IResult Delete(Solution solution);
        IResult Remove(Solution solution);
    }
}
