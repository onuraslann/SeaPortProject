using Business.Abstract;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class EquipmentManager : IEquipmentService
    {
        IEquipmentDal _equipmentDal;

        public EquipmentManager(IEquipmentDal equipmentDal)
        {
            _equipmentDal = equipmentDal;
        }

        public IResult Add(Equipment equipment)
        {
            _equipmentDal.Add(equipment);
            return new SuccessResult();
        }

        public IResult Delete(Equipment equipment)
        {

            _equipmentDal.Delete(equipment);
            return new SuccessResult();
        }

        public IDataResult<List<Equipment>> GetAll()
        {
            return new SuccessDataResult<List<Equipment>>(_equipmentDal.GetAll(), "Listelenme başarılı");
        }
    }
}
