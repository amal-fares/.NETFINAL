using Examen.ApplicationCore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Services
{
    public static class PassengerExtension
    {
            public static void UpperFullName(this Passenger a ) {

                 a.FirstName = a.FirstName[0].ToString().ToUpper()+a.FirstName.Substring(1);
               a.LastName = a.LastName[0].ToString().ToUpper() + a.LastName.Substring(1);
             }*/
    }
}
