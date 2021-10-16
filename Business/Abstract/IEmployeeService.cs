using Core.Utilities.Result;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IEmployeeService
    {
        IDataResult<List<Employee>> GetAll();

        IResult Add(Employee  employee);

        IDataResult<List<Employee>> GetByAge(int age);
        IResult Update(Employee employee);
        IResult CheckIfTransaction(Employee employee);

    }
}
