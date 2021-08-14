using Core.Utilities.Result;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IShipService
    {

        IDataResult<List<Ship>> GetAll();
        IDataResult<List<Ship>> GetByShipType(int shiptype);

        IResult Add(Ship  ship);

        IResult Delete(Ship ship);

        IDataResult<List<ShipDetailDto>> GetByDtos();

        
    }
}
