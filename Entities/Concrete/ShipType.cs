using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
  public  class ShipType:IEntity
    {

        public int Id { get; set; }

        public string TypeName { get; set; }
    }
}
