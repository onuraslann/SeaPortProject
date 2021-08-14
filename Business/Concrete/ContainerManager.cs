using Business.Abstract;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ContainerManager : IContainerService
    {
        IContainerDal _containerDal;

        public ContainerManager(IContainerDal containerDal)
        {
            _containerDal = containerDal;
        }

        public IResult Add(Container container)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(Container container)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Container>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Container>> GetByPortId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
