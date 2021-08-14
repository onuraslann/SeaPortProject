using Core.Utilities.Result;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IShipownerService
    {

        IDataResult<List<Shipowner>> GetAll();

        IResult Add(Shipowner  shipowner);

        IResult Delete(Shipowner shipowner);

  
    }
}
