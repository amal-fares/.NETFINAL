using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Domain
{
    public class Passenger
    {
        [Key, MaxLength(7)]
        public string PassportNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [StringLength(maximumLength: 25, MinimumLength = 7, ErrorMessage = "un message d'erreur")]
        public int PassengerId { get; set; }

        [Display(Name = "Date of Birth"), DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }
        [RegularExpression("[0-9]{8}")]
        public int TelNumber { get; set; }
        [DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set; }
        public virtual List<Ticket> tickets { get; set; }
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
