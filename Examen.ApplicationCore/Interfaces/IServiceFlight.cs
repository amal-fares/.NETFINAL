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

    }
}
