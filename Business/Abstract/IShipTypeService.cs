using Core.Utilities.Result;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IShipTypeService
    {
        IDataResult<List<ShipType>> GetAll();
        IResult Add(ShipType  shipType);
    }
}
