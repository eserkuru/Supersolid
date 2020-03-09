using System;
using System.Linq;
using Core.Utilities.Result;
using System.Collections.Generic;
using Supersolid.Entities.Concrete;
using Supersolid.Business.Abstract;
using Supersolid.Business.Constants;
using Supersolid.DataAccess.Abstract;

namespace Supersolid.Business.Concrete
{
    public class SolutionGroupManager : ISolutionGroupService
    {
        private readonly ISolutionGroupDal _solutionGroupDal;

        public SolutionGroupManager(ISolutionGroupDal solutionGroupDal)
        {
            _solutionGroupDal = solutionGroupDal;
        }

        public IDataResult<SolutionGroup> GetById(Guid id)
        {
            return new SuccessDataResult<SolutionGroup>(_solutionGroupDal.Get(sg => sg.Id == id));
        }

        public IDataResult<List<SolutionGroup>> GetList()
        {
            return new SuccessDataResult<List<SolutionGroup>>(_solutionGroupDal.GetList().ToList());
        }

        public IResult Add(SolutionGroup solutionGroup)
        {
            _solutionGroupDal.Add(solutionGroup);
            return new SuccessResult(Messages.AddedSuccessfully);
        }

        public IResult Update(SolutionGroup solutionGroup)
        {
            _solutionGroupDal.Update(solutionGroup);
            return new SuccessResult(Messages.AddedSuccessfully);
        }

        public IResult Delete(SolutionGroup solutionGroup)
        {
            _solutionGroupDal.Delete(solutionGroup);
            return new SuccessResult(Messages.AddedSuccessfully);
        }

        public IResult Remove(SolutionGroup solutionGroup)
        {
            _solutionGroupDal.Remove(solutionGroup);
            return new SuccessResult(Messages.AddedSuccessfully);
        }
    }
}
