using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Domain
{
    public class Staff : Passenger
    {
        public string Function { get; set; }
        public DateTime EmployementDate { get; set; }
     
        public float Salary { get; set; }
        public override string ToString()
        {
            return EmployementDate + " " + Function + " " + Salary;
        }

    }
}
