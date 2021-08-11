using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Container:IEntity
    {
        public int Id { get; set; }

        public string TypeName { get; set; }

        public Nullable<Double> Length { get; set; }
        public Nullable<Double> Width { get; set; }

        public Nullable<Double> Height { get; set; }
        public Nullable<Double> Capacity { get; set; }

        public Nullable<Double> CargoWeight { get; set; }


        public int ColorId { get; set; }
        public int PortId { get; set; }

    
    }
}
