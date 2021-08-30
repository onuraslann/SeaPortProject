using Business.Abstract;
using Business.Constants;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class PortManager : IPortService
    {
        IPortDal _portDal;

        public PortManager(IPortDal portDal)
        {
            _portDal = portDal;
        }

        public IResult Add(Port port)
        {
            _portDal.Add(port);
            return new SuccessResult();
        }

        public IResult Delete(Port port)
        {
            _portDal.Delete(port);
            return new SuccessResult();
        }

        public IDataResult<List<Port>> GetAll()
        {
            return new SuccessDataResult<List<Port>>(_portDal.GetAll(),Messages.PortList);
        }

        public IDataResult<List<Port>> GetByName(string name)
        {
            return new SuccessDataResult<List<Port>>(_portDal.GetAll(x=> x.PortName==name));
        }
    }
}
