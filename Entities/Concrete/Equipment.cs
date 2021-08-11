using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Equipment:IEntity
    {
        public int Id { get; set; }
        public string EquipmentName { get; set; }
  
        public int Quantity { get; set; }
 
        public int PortId { get; set; }


    }
}
