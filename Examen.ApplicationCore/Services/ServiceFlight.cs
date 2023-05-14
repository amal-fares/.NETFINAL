using Examen.ApplicationCore.Domain;
using Examen.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Services
{
    public class ServiceFlight : Service<Flight>, IServiceFlight
    {

        public List<Flight> Flights { get; set; } = new List<Flight>();

        public List<DateTime> GetFlightDates(string destination)
        {
            List<DateTime> dates = new List<DateTime>();

            for (int i = 0; i < Flights.Count; i++)
            {
                if (Flights[i].Destination == destination)
                {
                    dates.Add(Flights[i].FlightDate);
                }
            }
            return dates;
            ///  //foreach (var flight in Flights)
            //{
            //    if (flight.destination == destination)
            //    {
            //        dates.Add(flight.flightDate);
            //    }
            //}
            void GetFlights(string filterType, string filterValue)
            {
                switch (filterType)
                {
                    case "Destination":
                        foreach (Flight f in Flights)
                        {
                            if (f.Destination.Equals(filterValue))
                                Console.WriteLine(f);
                        }
                        break;
                    case "FlightDate":
                        foreach (Flight f in Flights)
                        {
                            if (f.FlightDate == DateTime.Parse(filterValue))

                                Console.WriteLine(f);

                        }
                        break;
                    case "EffectiveArrival":
                        foreach (Flight f in Flights)
                        {
                            if (f.EffectiveArrival == DateTime.Parse(filterValue))
                                Console.WriteLine(f);
                        }
                        break;
                }
            }

        }
    }
}
    
