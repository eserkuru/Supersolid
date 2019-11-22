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
    public class LayerManager : ILayerService
    {
        private readonly ILayerDal _layerDal;
        public LayerManager(ILayerDal layerDal)
        {
            _layerDal = layerDal;
        }

        public IDataResult<Layer> GetById(Guid id)
        {
            return new SuccessDataResult<Layer>(_layerDal.Get(l => l.Id == id));
        }

        public IDataResult<List<Layer>> GetList()
        {
            return new SuccessDataResult<List<Layer>>(_layerDal.GetList().ToList());
        }

        public IResult Add(Layer layer)
        {
            _layerDal.Add(layer);
            return new SuccessResult(Messages.AddedSuccessfully);
        }

        public IResult Update(Layer layer)
        {
            _layerDal.Update(layer);
            return new SuccessResult(Messages.UpdatedSuccessfully);
        }

        public IResult Delete(Layer layer)
        {
            _layerDal.Delete(layer);
            return new SuccessResult(Messages.DeletedSuccessfully);
        }

        public IResult Remove(Layer layer)
        {
            _layerDal.Remove(layer);
            return new SuccessResult(Messages.RemovedSuccessfully);
        }
    }
}
