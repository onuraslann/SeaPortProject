using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Transaction;
using Core.Aspects.Validation;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class EmployeeManager : IEmployeeService
    {
        IEmployeeDal _employeDal;

        public EmployeeManager(IEmployeeDal employeDal)
        {
            _employeDal = employeDal;
        }

        [ValidationAspect(typeof(EmployeValidator))]
        public IResult Add(Employee employee)
        {
            _employeDal.Add(employee);
            return new SuccessResult(Messages.EmployeAdded);

                }
    [TransactionScopeAspect]
        public IResult CheckIfTransaction(Employee employee)
        {
            _employeDal.Update(employee);
            _employeDal.Add(employee);
            return new SuccessResult();
        }

        public IDataResult<List<Employee>> GetAll()
        {
            return new SuccessDataResult<List<Employee>>(_employeDal.GetAll());
        }

        public IDataResult<List<Employee>> GetByAge(int age)
        {
            return new SuccessDataResult<List<Employee>>(_employeDal.GetAll(x=> x.Age>age));
        }

        public IResult Update(Employee employee)
        {
            _employeDal.Update(employee);
            return new SuccessResult(Messages.EmployeeUpdate);
        }
    }
}
