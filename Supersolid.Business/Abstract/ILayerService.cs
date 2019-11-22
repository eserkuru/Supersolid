using System;
using System.Collections.Generic;
using Core.Utilities.Result;
using Supersolid.Entities.Concrete;

namespace Supersolid.Business.Abstract
{
    public interface ILayerService
    {
        IDataResult<Layer> GetById(Guid id);
        IDataResult<List<Layer>> GetList();
        IResult Add(Layer layer);
        IResult Update(Layer layer);
        IResult Delete(Layer layer);
        IResult Remove(Layer layer);
    }
}
