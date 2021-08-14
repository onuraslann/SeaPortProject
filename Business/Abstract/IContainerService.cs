using Core.Utilities.Result;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IContainerService
    {

        IDataResult<List<Container>> GetAll();

        IResult Add(Container container);

        IResult Delete(Container container);

        IDataResult<List<Container>> GetByPortId(int id);
    }
}

