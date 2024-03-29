﻿using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
   public class Image:IEntity
    {
        public int Id { get; set; }
        public int ShipId { get; set; }
        public DateTime Date { get; set; }
        public string ImagePath { get; set; }
    }
}
