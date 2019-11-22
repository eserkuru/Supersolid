using System;
using System.Collections.Generic;
using Core.Utilities.Result;
using Supersolid.Entities.Concrete;

namespace Supersolid.Business.Abstract
{
    public interface IProjectService
    {
        IDataResult<Project> GetById(Guid id);
        IDataResult<List<Project>> GetList();
        IResult Add(Project project);
        IResult Update(Project project);
        IResult Delete(Project project);
        IResult Remove(Project project);
    }
}
