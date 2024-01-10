using project2_begin.Forms.CompanyForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace project2_begin.Classes
{
    static class Funcitons
    {
        static public void addDefaultTrip1(Vehicle vehicle, string companyName, DateTime time)
        {
            Trip trip = new Trip("Demiryolu",vehicle.PassengerCapacity,companyName);
            trip.goingRoute = defaultTrip.goingRoutes1.Select(route => new Route(route.Deparature,route.Destination,route.Distance,route.price)).ToList();
            trip.returnRoute = defaultTrip.returnRoutes1.Select(route => new Route(route.Deparature, route.Destination, route.Distance, route.price)).ToList();
            trip.time = time;
            trip.vehicle = vehicle;
            generateSeatSpaceToTrip(trip);
            Transport.trips.Add(trip);
        }
        static public void addDefaultTrip2(Vehicle vehicle, string companyName, DateTime time)
        {
            Trip trip = new Trip("Demiryolu",vehicle.PassengerCapacity, companyName);
            trip.goingRoute = defaultTrip.goingRoutes2.Select(route => new Route(route.Deparature, route.Destination, route.Distance, route.price)).ToList();
            trip.returnRoute = defaultTrip.returnRoutes2.Select(route => new Route(route.Deparature, route.Destination, route.Distance, route.price)).ToList();
            trip.time = time;
            trip.vehicle = vehicle;
            generateSeatSpaceToTrip(trip);      
            Transport.trips.Add(trip);
        }
        static public void addDefaultTrip3(Vehicle vehicle, string companyName, DateTime time)
        {
            Trip trip = new Trip("Karayolu", vehicle.PassengerCapacity, companyName);
            trip.goingRoute = defaultTrip.goingRoutes3.Select(route => new Route(route.Deparature, route.Destination, route.Distance, route.price)).ToList();
            trip.returnRoute = defaultTrip.returnRoutes3.Select(route => new Route(route.Deparature, route.Destination, route.Distance, route.price)).ToList();
            trip.time = time;
            trip.vehicle = vehicle;
            
            generateSeatSpaceToTrip(trip);
            Transport.trips.Add(trip);
        }
        static public void addDefaultTrip4(Vehicle vehicle, string companyName, DateTime time)
        {

            Trip trip = new Trip("Karayolu", vehicle.PassengerCapacity, companyName);
            trip.goingRoute = defaultTrip.goingRoutes4.Select(route => new Route(route.Deparature, route.Destination, route.Distance, route.price)).ToList();
            trip.returnRoute = defaultTrip.returnRoutes4.Select(route => new Route(route.Deparature, route.Destination, route.Distance, route.price)).ToList();
            trip.time = time;
            trip.vehicle = vehicle;            
            generateSeatSpaceToTrip(trip);
            Transport.trips.Add(trip);
        }
        static public void addDefaultTrip5(Vehicle vehicle, string companyName, DateTime time)
        {
            Trip trip = new Trip("Havayolu", vehicle.PassengerCapacity, companyName);
            trip.goingRoute = defaultTrip.goingRoutes5.Select(route => new Route(route.Deparature, route.Destination, route.Distance, route.price)).ToList();
            trip.returnRoute = defaultTrip.returnRoutes5.Select(route => new Route(route.Deparature, route.Destination, route.Distance, route.price)).ToList();
            trip.time = time;
            trip.vehicle = vehicle;
            generateSeatSpaceToTrip(trip);
            Transport.trips.Add(trip);

        }
        static public void addDefaultTrip6(Vehicle vehicle, string companyName, DateTime time)
        {
            Trip trip = new Trip("Havayolu", vehicle.PassengerCapacity,companyName);
            trip.goingRoute = defaultTrip.goingRoutes6.Select(route => new Route(route.Deparature, route.Destination, route.Distance, route.price)).ToList();
            trip.returnRoute = defaultTrip.returnRoutes6.Select(route => new Route(route.Deparature, route.Destination, route.Distance, route.price)).ToList();

            trip.time = time;
            trip.vehicle = vehicle;
            generateSeatSpaceToTrip(trip);           
            Transport.trips.Add(trip);
        }
        static public void copyVehicleMem() { 
        foreach(Company company in Transport.Companies) {
                Transport.vehicles.AddRange(company.vehicles);
            }
        }
        static public void generateSeatSpace(Route route,int passengerCount)
        {
            route.isEmptySeat = new List<bool>();
            for (int i = 0;i<passengerCount;i++)route.isEmptySeat.Add(false);
        }
        static public void generateSeatSpaceToTrip(Trip trip)
        {
            foreach(var route in trip.sumRoutes())
            {
                generateSeatSpace(route, trip.vehicle.PassengerCapacity);
            }
        }
        static public void generateDefaultCompanies()
        {
            Company add = new Company("A", "A", "A", new Salaries(5000, 5000, 5000), new Salaries(2000, 2000, 2000), 0, 10, 0, 0);
            add.addVehicle(new Bus(20,add.companyId,"Gasoline",add));
            add.addVehicle(new Bus(15,add.companyId,"Gasoline",add));
            Transport.Companies.Add(add);

            add = new Company("B", "B", "B", new Salaries(3000, 3000, 3000), new Salaries(1500, 1500, 1500),5,0,0,0);
            add.addVehicle(new Bus(15, add.companyId, "Motorine", add));
            add.addVehicle(new Bus(20, add.companyId, "Motorine", add));
            Transport.Companies.Add(add);

            add = new Company("C", "C", "C", new Salaries(4000,4000,10000), new Salaries(2000, 2000, 6000), 6, 0, 0,25);
            add.addVehicle(new Bus(20, add.companyId, "Motorine", add));
            add.addVehicle(new AirPlane(30, add.companyId, "Gas", add));
            add.addVehicle(new AirPlane(30, add.companyId, "Gas", add));
            Transport.Companies.Add(add);

            add = new Company("D", "D", "D", new Salaries(2000, 2000, 2000), new Salaries(1000, 1000, 1000), 0, 0, 3,0);
            add.addVehicle(new Train(25, add.companyId, "Electric", add));
            add.addVehicle(new Train(25, add.companyId, "Electric", add));
            add.addVehicle(new Train(25, add.companyId, "Electric", add));
            Transport.Companies.Add(add);

            add = new Company("F", "F", "F", new Salaries(7500, 7500, 7500), new Salaries(4000, 4000, 4000), 0, 0, 0, 20);
            add.addVehicle(new AirPlane(30, add.companyId, "Gas", add));
            add.addVehicle(new AirPlane(30, add.companyId, "Gas", add));
            Transport.Companies.Add(add);

            copyVehicleMem();

            for (int i = 4; i <= 10; i++)
            {
                addDefaultTrip3(Transport.vehicles[0], Transport.Companies[0].companyName, new DateTime(2023, 12, i));
                addDefaultTrip3(Transport.vehicles[1], Transport.Companies[0].companyName, new DateTime(2023, 12, i));
                addDefaultTrip3(Transport.vehicles[2], Transport.Companies[1].companyName, new DateTime(2023, 12, i));
                addDefaultTrip4(Transport.vehicles[3], Transport.Companies[1].companyName, new DateTime(2023, 12, i));
                addDefaultTrip4(Transport.vehicles[4], Transport.Companies[2].companyName, new DateTime(2023, 12, i));
                addDefaultTrip5(Transport.vehicles[5], Transport.Companies[2].companyName, new DateTime(2023, 12, i));
                addDefaultTrip5(Transport.vehicles[6], Transport.Companies[2].companyName, new DateTime(2023, 12, i));
                addDefaultTrip1(Transport.vehicles[7], Transport.Companies[3].companyName, new DateTime(2023, 12, i));
                addDefaultTrip2(Transport.vehicles[8], Transport.Companies[3].companyName, new DateTime(2023, 12, i));
                addDefaultTrip2(Transport.vehicles[9], Transport.Companies[3].companyName, new DateTime(2023, 12, i));
                addDefaultTrip6(Transport.vehicles[10], Transport.Companies[4].companyName, new DateTime(2023, 12, i));
                addDefaultTrip6(Transport.vehicles[11], Transport.Companies[4].companyName, new DateTime(2023, 12, i));
            }
        }
        public static int sumRoutePrice(Trip trip)
        {
            int sum = 0;
            foreach(Route route in trip.sumRoutes())
            {
                sum += route.price;
            }
            return sum;
        }
        
    }
}
