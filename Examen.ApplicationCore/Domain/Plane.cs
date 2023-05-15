using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Domain
{
    public class Plane
    { 
        public int PlaneId { get; set; }
        public PlaneType PlaneType { get; set; }
        public DateTime ManufactureDate { get; set; }
        [Range(0, int.MaxValue)]
        public int Capacity { get; set; }
        public virtual List<Flight> Flights { get; set; }
        public override string ToString()
        {
            return Capacity + " " + PlaneId + " " + PlaneType + " " + ManufactureDate + " " + Flights;
        }

    }
}
