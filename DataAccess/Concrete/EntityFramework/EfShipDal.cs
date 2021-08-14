using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfShipDal : EntityRepositoryBase<Ship, ShipContext>, IShipDal
    {
        public List<ShipDetailDto> GetByDto()
        {
            using (ShipContext context = new ShipContext())
            {
                var result = from p in context.Shipowners
                             join
                     c in context.Ships on
                      p.Id equals c.ShipownerId
                             join r in context.ShipTypes on
                           c.ShipTypeId equals r.Id
                             select new ShipDetailDto
                             {

                                 Flag = c.Flag,
                                 Id = c.Id,
                                 ShipName = c.ShipName,
                                 Phone = p.Phone,
                                 ShipownerName = p.ShipownerName,
                                 Record = c.Record,
                                 TypeName = r.TypeName

                             };
                return result.ToList();
                             
            }
        }
    }
}
