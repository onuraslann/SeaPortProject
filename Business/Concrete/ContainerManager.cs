using Business.Abstract;
using Business.BusinessAspects;
using Business.Constants;
using Core.Aspects.Caching;
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

        [SecuredOperation("admin,editör")]
        public IResult Add(Container container)
        {
            _containerDal.Add(container);
            return new SuccessResult(Messages.ContainerAdded);
        }

        public IResult Delete(Container container)
        {

            _containerDal.Delete(container);
            return new SuccessResult(Messages.ContainerDeleted);
        }
        [CacheAspect]
        public IDataResult<List<Container>> GetAll()
        {
            return new SuccessDataResult<List<Container>>(_containerDal.GetAll());
        }

        public IDataResult<List<Container>> GetByPortId(int id)
        {
            return new SuccessDataResult<List<Container>>(_containerDal.GetAll(x=>x.PortId==id));
        }
    }
}
