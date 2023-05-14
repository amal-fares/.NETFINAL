// See https://aka.ms/new-console-template for more information
using Examen.ApplicationCore.Domain;
using Examen.ApplicationCore.Services;

//Plane plane = new Plane();
//plane.PlaneId = 1;
//plane.Capacity = 500;
//plane.PlaneType = PlaneType.Airbus;
//plane.ManufactureDate = new DateTime(2023, 05, 02);


// 8- Création d'un constructeur

// 9-
//Plane plane2 = new Plane(PlaneType.Boing,480,new DateTime(2023, 04, 30));

//Plane plane3 = new Plane
//{
//    PlaneId = 1,
//    Capacity = 1,
//    ManufactureDate = new DateTime(2023, 04, 12),
//    PlaneType = PlaneType.Airbus
//};

// 10 - Création des méthode checkprofile();

// 11 -
Passenger p = new Passenger();
//p.LastName= "test";
//p.PassengerType();

//Staff s = new Staff();
//s.PassengerType();

//Traveller t = new Traveller();
//t.PassengerType();


ServiceFlight sf = new ServiceFlight();

sf.Flights = TestData.listFlights;