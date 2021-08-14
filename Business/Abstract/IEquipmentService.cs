using Core.Utilities.Result;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IEquipmentService
    {

        IDataResult<List<Equipment>> GetAll();

        IResult Add(Equipment equipment);

        IResult Delete(Equipment equipment);
    }
}
