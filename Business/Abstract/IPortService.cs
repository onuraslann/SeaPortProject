using Core.Utilities.Result;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IPortService
    {
        IDataResult<List<Port>> GetAll();

        IResult Add(Port port);

        IResult Delete(Port  port);

        IDataResult<List<Port>> GetByName(string name);



    }
}
