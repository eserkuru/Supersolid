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
    public class SolutionManager : ISolutionService
    {
        private readonly ISolutionDal _solutionDal;

        public SolutionManager(ISolutionDal solutionDal)
        {
            _solutionDal = solutionDal;
        }

        public IDataResult<Solution> GetById(Guid id)
        {
            return new SuccessDataResult<Solution>(_solutionDal.Get(s => s.Id == id));
        }

        public IDataResult<Solution> GetFullById(Guid id)
        {
            return new SuccessDataResult<Solution>(_solutionDal.GetFull(s => s.Id == id));
        }

        public IDataResult<List<Solution>> GetList()
        {
            return new SuccessDataResult<List<Solution>>(_solutionDal.GetList().ToList());
        }

        public IDataResult<List<Solution>> GetFullList()
        {
            return new SuccessDataResult<List<Solution>>(_solutionDal.GetFullList().ToList());
        }

        public IResult Add(Solution solution)
        {
            _solutionDal.Add(solution);
            return new SuccessResult(Messages.AddedSuccessfully);
        }

        public IResult Update(Solution solution)
        {
            _solutionDal.Update(solution);
            return new SuccessResult(Messages.UpdatedSuccessfully);
        }

        public IResult Delete(Solution solution)
        {
            _solutionDal.Delete(solution);
            return new SuccessResult(Messages.DeletedSuccessfully);
        }

        public IResult Remove(Solution solution)
        {
            _solutionDal.Remove(solution);
            return new SuccessResult(Messages.RemovedSuccessfully);
        }

        public IResult CreateFile(Solution solution)
        {
            solution.IsFileCreated = true;
            _solutionDal.Update(solution);
            return new SuccessResult(Messages.FileCreatedSuccessfully);
        }
    }
}
