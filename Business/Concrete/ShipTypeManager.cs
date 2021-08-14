using Business.Abstract;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ShipTypeManager : IShipTypeService
    {
        IShipTypeDal _shipTypeDal;

        public ShipTypeManager(IShipTypeDal shipTypeDal)
        {
            _shipTypeDal = shipTypeDal;
        }

        public IResult Add(ShipType shipType)
        {
            _shipTypeDal.Add(shipType);
            return new SuccessResult();
        }

        public IDataResult<List<ShipType>> GetAll()
        {
            return new SuccessDataResult<List<ShipType>>(_shipTypeDal.GetAll());
        }
    }
}
