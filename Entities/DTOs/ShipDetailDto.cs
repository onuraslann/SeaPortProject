using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class ShipDetailDto:IDTO
    {
        public int Id { get; set; }
        public string ShipName { get; set; }

        public string Flag { get; set; }
        public string Record { get; set; }
        public string ShipownerName { get; set; }
        public string Phone { get; set; }
        public string TypeName { get; set; }
    }
}
