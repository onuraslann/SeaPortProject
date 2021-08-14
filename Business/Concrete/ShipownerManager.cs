using Business.Abstract;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ShipownerManager : IShipownerService
    {
        IShipownerDal _shipownerDal;

        public ShipownerManager(IShipownerDal shipownerDal)
        {
            _shipownerDal = shipownerDal;
        }

        public IResult Add(Shipowner shipowner)
        {
            _shipownerDal.Add(shipowner);
            return new SuccessResult();
        }

        public IResult Delete(Shipowner shipowner)
        {
            _shipownerDal.Delete(shipowner);
            return new SuccessResult();
        }

        public IDataResult<List<Shipowner>> GetAll()
        {
            return new SuccessDataResult<List<Shipowner>>(_shipownerDal.GetAll());
        }
    }
}
