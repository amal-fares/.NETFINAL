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
        private IUnitOfWork unitOfWork;
        public ServiceFlight(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
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
            //} //avec la methode linq question 9
            //var query = from f in Flights
            //            where f.destination==destination
            //           select f.flightDate;
            //           return query.ToList();
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
            ///10
            void ShowFlightDetails(Plane plane)
            {
                var query = Flights
                    .Where(f => f.Plane.PlaneId == plane.PlaneId)
                    .Select(f => new { f.FlightDate, f.Destination });
                foreach (var item in query) { Console.WriteLine(item); }
            }
            //11
            int ProgrammedFlightNumber(DateTime startDate)
            {
                var query = Flights
                    .Count(f => f.FlightDate >= startDate && (f.FlightDate - startDate).TotalDays < 7);
                return query;
            }
            //12

            double DurationAverage(string destination)
            {
                var query = Flights
                    .Where(f => f.Destination.Equals("destination"))
                    .Average(f => f.EstimatedDuration);
                return query;
            }
            ///13 
            List<Flight> OrderedDurationFlights()
            {
                var query = Flights
                    .OrderByDescending(f => f.EstimatedDuration).ToList();

                return query;
            }
            //14
            List<Passenger> SeniorTravellers(Flight flight)
            {
                var query = flight.Passengers.OfType<Traveller>()
             .Where(p => p is Traveller)
                    .OrderBy(p => p.BirthDate).Take(3);
                List<Passenger> pas = new List<Passenger>(query);
                return pas;
            }
            //Partie 6.1
            //    private IGenericRepository<Flight> genericRepository;

            //public ServiceFlight(IGenericRepository<Flight> genericRepository)
            //{
            //    this.genericRepository = genericRepository;
            //}

            //Partie 6.2

       

     void Add(Flight f)
        {
            // genericRepository.Add(f);
            unitOfWork.Repository<Flight>().Add(f);
        }

         void Update(Flight f)
        {
            // genericRepository.Update(f);
            unitOfWork.Repository<Flight>().Update(f);
        }

        IList<Flight> GetAll()
        {
            //return genericRepository.GetAll().ToList();
            return unitOfWork.Repository<Flight>().GetAll().ToList();
        }
        //15
        void DestinationGroupedFlights()
            {
                var query = Flights
                    .GroupBy(f => f.Destination);
                foreach (var f in query)
                {
                    Console.WriteLine(f.Key);
                    foreach (var g in f)
                    {
                        Console.WriteLine(g.FlightDate);
                    }
                }
            }
        }
    }
}
    
