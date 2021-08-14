using Business.Abstract;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ShipManager : IShipService
    {
        IShipDal _shipDal;

        public ShipManager(IShipDal shipDal)
        {
            _shipDal = shipDal;
        }

        public IResult Add(Ship ship)
        {
            _shipDal.Add(ship);
            return new SuccessResult();
        }

        public IResult Delete(Ship ship)
        {
            _shipDal.Delete(ship);
            return new SuccessResult();
        }

        public IDataResult<List<Ship>> GetAll()
        {
            return new SuccessDataResult<List<Ship>>(_shipDal.GetAll());
        }

        public IDataResult<List<ShipDetailDto>> GetByDtos()
        {
            return new SuccessDataResult<List<ShipDetailDto>>(_shipDal.GetByDto());
        }

        public IDataResult<List<Ship>> GetByShipType(int shiptype)
        {
            return new SuccessDataResult<List<Ship>>(_shipDal.GetAll(x=> x.ShipTypeId==shiptype));
        }
    }
}
