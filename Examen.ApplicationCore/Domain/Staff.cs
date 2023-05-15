using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Domain
{
    public class Staff : Passenger
    {
        public string Function { get; set; }
        public DateTime EmployementDate { get; set; }
        [DataType(DataType.Currency)]///
        public float Salary { get; set; }
        public override string ToString()
        {
            return EmployementDate + " " + Function + " " + Salary;
        }
        public override void PassengerType()
        {
            base.PassengerType();
            Console.WriteLine("I am passenger I am a staff member");
        }

    }
}
