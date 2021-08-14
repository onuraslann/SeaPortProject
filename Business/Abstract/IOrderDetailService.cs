using Core.Utilities.Result;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IOrderDetailService
    {
        IDataResult<List<OrderDetail>> GetAll();

        IResult Add(OrderDetail  orderDetail);

        IResult Delete(OrderDetail  orderDetail);

        IDataResult<List<OrderDetail>> GetByProduct(int product );

    }
}
