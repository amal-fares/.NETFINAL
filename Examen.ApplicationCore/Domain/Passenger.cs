using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Domain
{
    public class Passenger
    {
        public string PassportNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public int TelNumber { get; set; }
        public string EmailAddress { get; set; }
        public virtual List<Flight> Flights { get; set; }
        public override string ToString()
        {
            return BirthDate + " " + EmailAddress + " " + TelNumber + " " + PassportNumber;
        }
        
        public bool CheckProfile(string fName, string lName)
        {
            return fName == FirstName && lName == LastName;
        }
        public bool CheckProfile1(string fName, string lName, string email)
        {
            return fName == FirstName && lName == LastName && email == EmailAdress;
        }
        
           public bool CheckProfile2(string fName, string lName, string email=null)
      {
          if (email==null)
              return fName == FirstName && lName == LastName;

          return fName == FirstName && lName == LastName && email == EmailAddress;
      }
   
        public virtual void PassengerType()
        {
            Console.WriteLine("I am passenger");
        }


    }
}
