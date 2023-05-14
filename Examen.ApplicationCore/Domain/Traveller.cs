using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Domain
{
    public class Traveller : Passenger
    {
        public string HealthInformation { get; set; }
        public string Nationality { get; set; }
        public override void PassengerType()
        {
            base.PassengerType();
            Console.WriteLine("I am passenger I am a traveller");
        }
    }
}
