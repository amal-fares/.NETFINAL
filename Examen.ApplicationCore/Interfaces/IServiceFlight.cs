using Examen.ApplicationCore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Interfaces
{
    public interface IServiceFlight : IService<Flight>
    {
        List<DateTime> GetFlightDates(string destination);
        void GetFlights(string filterType, string filterValue);
        void ShowFlightDetails(Plane plane);
        int ProgrammedFlightNumber(DateTime startDate);

        double DurationAverage(string destination);
        List<Flight> OrderedDurationFlights();
        List<Passenger> SeniorTravellers(Flight flight);
        void DestinationGroupedFlights();
            public void Add(Flight f);
            public void Update(Flight f);
            public IList<Flight> GetAll();
        }
}
