using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Ship: IEntity
    {

        public int Id { get; set; }
        public string ShipName { get; set; }

        public int ShipownerId { get; set; }
        public int ShipTypeId { get; set; }

        public string Flag { get; set; }

        public int RegistrationNumber { get; set; }
        public int PortId { get; set; }

        public string Record { get; set; }

        public int ImoNo { get; set; }
        public Boolean Status { get; set; }

        public int DockNumber { get; set; }

        public DateTime DockingDate { get; set; }
        public DateTime LeavingDate { get; set; }

        public Nullable<Double> DTW { get; set; }
        public Nullable<Double> GRT { get; set; }
        public Nullable<Double> Breadth { get; set; }
        public Nullable<Double> Length { get; set; }
    }
}
