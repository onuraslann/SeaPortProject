using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
   public class Product:IEntity
    {
        public int Id { get; set; }
        public string ProductName { get; set; }

        public Nullable<Double> Price { get; set; }

        public int CategoryId { get; set; }

    }
}
