﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Domain
{
    public class Flight
    {
        public int FlightId { get; set; }
        public DateTime FlightDate { get; set; }
        public int EstimatedDuration { get; set; }
        public DateTime EffectiveArrival { get; set; }
        public string Departure { get; set; }
        public string Destination { get; set; }
        public virtual List<Passenger> Passengers { get; set; }
        public virtual Plane Plane { get; set; }
        [ForeignKey(nameof(Plane))]
        public int? PlaneFk { get; set; }
        public virtual List<Ticket> tickets { get; set; }
        public override string ToString()
        {
            return Destination + " " + Departure + " " + FlightDate + " " + EffectiveArrival + " " + EstimatedDuration + " " + plane;
        }
    }
    }
