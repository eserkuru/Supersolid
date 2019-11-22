using System;
using System.Collections.Generic;
using System.Linq;
using Core.Utilities.Result;
using Supersolid.Business.Abstract;
using Supersolid.Business.Constants;
using Supersolid.DataAccess.Abstract;
using Supersolid.Entities.Concrete;

namespace Supersolid.Business.Concrete
{
    public class ProjectManager : IProjectService
    {
        private readonly IProjectDal _projectDal;

        public ProjectManager(IProjectDal projectDal)
        {
            _projectDal = projectDal;
        }
        public IDataResult<Project> GetById(Guid id)
        {
            return new SuccessDataResult<Project>(_projectDal.Get(p => p.Id == id));
        }

        public IDataResult<List<Project>> GetList()
        {
            return new SuccessDataResult<List<Project>>(_projectDal.GetList().ToList());
        }

        public IResult Add(Project project)
        {
            _projectDal.Add(project);
            return new SuccessResult(Messages.AddedSuccessfully);
        }

        public IResult Update(Project project)
        {
            _projectDal.Update(project);
            return new SuccessResult(Messages.UpdatedSuccessfully);
        }

        public IResult Delete(Project project)
        {
            _projectDal.Delete(project);
            return new SuccessResult(Messages.DeletedSuccessfully);
        }

        public IResult Remove(Project project)
        {
            _projectDal.Remove(project);
            return new SuccessResult(Messages.RemovedSuccessfully);
        }
    }
}
