using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Port:IEntity
    {

        public int Id { get; set; }
        public string PortName { get; set; }
        public  Nullable<Double> TotalPortArea { get; set; }
        public int TotalDocks { get; set; }
        public Nullable<Double> MaxDepth { get; set; }
        public Nullable<Double> DockLength { get; set; }

        public Nullable<Double> ShipLength { get; set; }

    }
}
