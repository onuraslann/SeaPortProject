using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Shipowner:IEntity
    {
        public int Id { get; set; }

        public string ShipownerName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int Address { get; set; }
      
    }
}
