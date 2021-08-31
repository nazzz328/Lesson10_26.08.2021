using System;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
        Transport ship = new Transport ("ship", 10, 400000);
        ship.InfoTransport();

        Car jeep = new Car ("Jeep", 6, 200000, 300, 70);
        jeep.InfoCar();

        Plane mig = new Plane ("MIG", 100, 20000000, 4, 12);
        mig.InfoPlane();

        Train ice = new Train ("ICE", 600, 50000000, 6, true);
        ice.InfoTrain();

        Light_car volvo = new Light_car ("Volvo", 3, 20000, 400, 40, false, true);
        volvo.InfoLightCar();

        Truck vaz = new Truck ("VAZ", 10, 40000, 200, 40, 10, true);
        vaz.InfoTruck();

        Civil_plane boeing = new Civil_plane ("Boeing", 300, 300000000, 4, 11, "Turkish Airlines", 200);
        boeing.InfoCivilPlane();

        Transport_plane airbus = new Transport_plane ("Airbus", 600, 400000000, 8, 9, 10, true);
        airbus.InfoTransportPlane();

        }
    }

    class Transport
    {
        public string Name { get; set; }
        public int Weight_t { get; set; }
        public int Price_dollars { get; set; }
        public Transport () {}
        public Transport (string Name, int Weight_t, int Price_dollars)
        {
            this.Name = Name;
            this.Weight_t = Weight_t;
            this.Price_dollars = Price_dollars;
        }
        
        
        public void InfoTransport()
        {
        System.Console.WriteLine($"Name: {Name};\nWeight: {Weight_t};\nPrice: {Price_dollars}.");
        System.Console.WriteLine();
        }
    }

    class Car : Transport
    {
    public int Max_driving_distance_km {get; set;}
    public int Tire_price {get;set;}
    public Car () {}
    public Car (string Name, int Weight_t, int Price_dollars, int Max_driving_distance_km, int Tire_price) : base(Name, Weight_t, Price_dollars)
    {
    this.Max_driving_distance_km = Max_driving_distance_km;
    this.Tire_price = Tire_price;
    }

    public void InfoCar()
        {
        System.Console.WriteLine($"Name: {Name};\nWeight: {Weight_t};\nPrice: {Price_dollars};\nMaximum driving distance in kilometers: {Max_driving_distance_km};\nPrice of a tire: {Tire_price}.");
        System.Console.WriteLine();
        }
    
    }

    class Plane : Transport
    {
    public int Number_of_engines {get;set;}
    public int Max_flight_height_km {get;set;}
    public Plane () {}
    public Plane (string Name, int Weight_t, int Price_dollars, int Number_of_engines, int Max_flight_height_km) : base (Name, Weight_t, Price_dollars)
    {
    this.Number_of_engines = Number_of_engines;
    this.Max_flight_height_km = Max_flight_height_km;
    }

    public void InfoPlane()
        {
        System.Console.WriteLine($"Name: {Name};\nWeight: {Weight_t};\nPrice: {Price_dollars};\nNumber of engines: {Number_of_engines}\nMaximum flight height in kilometers: {Max_flight_height_km}.");
        System.Console.WriteLine();
        }
    }

    class Train : Transport
    {
    public int Number_of_wagons {get;set;}
    public bool Has_air_conditioning {get;set;}
    public Train () {}
    public Train (string Name, int Weight_t, int Price_dollars, int Number_of_wagons, bool Has_air_conditioning) : base (Name, Weight_t, Price_dollars)
    {
    this.Number_of_wagons = Number_of_wagons;
    this.Has_air_conditioning = Has_air_conditioning;
    }

    public void InfoTrain()
        {
        System.Console.WriteLine($"Name: {Name};\nWeight: {Weight_t};\nPrice: {Price_dollars};\nNumber of wagons: {Number_of_wagons};\nDoes it have air conditioning? {Has_air_conditioning}.");
        System.Console.WriteLine();
        }
    }

    class Light_car : Car 
    {
    public bool Has_tv {get;set;}
    public bool Loan_possible {get;set;}
    public Light_car () {}
    public Light_car (string Name, int Weight_t, int Price_dollars, int Max_driving_distance_km, int Tire_price, bool Has_tv, bool Loan_possible) : base(Name, Weight_t, Price_dollars, Max_driving_distance_km, Tire_price)
     {
    this.Has_tv = Has_tv;
    this.Loan_possible = Loan_possible;
     }

     public void InfoLightCar()
        {
        System.Console.WriteLine($"Name: {Name};\nWeight: {Weight_t};\nPrice: {Price_dollars};\nMaximum driving distance in kilometers: {Max_driving_distance_km};\nPrice of a tire: {Tire_price};\nDoes it have TV? {Has_tv};\nIs loaning possible? {Loan_possible}.");
        System.Console.WriteLine();
        }
    }

    class Truck: Car
    {
    public int Capacity_t {get;set;}
    public bool Fluid_transport_possible {get;set;}
    public Truck () {}
    public Truck (string Name, int Weight_t, int Price_dollars, int Max_driving_distance_km, int Tire_price, int Capacity_t, bool Fluid_transport_possible) : base(Name, Weight_t, Price_dollars, Max_driving_distance_km, Tire_price)
    {
    this.Capacity_t = Capacity_t;
    this.Fluid_transport_possible = Fluid_transport_possible;    
    }

    public void InfoTruck()
        {
        System.Console.WriteLine($"Name: {Name};\nWeight: {Weight_t};\nPrice: {Price_dollars};\nMaximum driving distance in kilometers: {Max_driving_distance_km};\nPrice of a tire: {Tire_price};\nCarrying capacity in tonnes: {Capacity_t};\nIs fluid transport possible? {Fluid_transport_possible}.");
        System.Console.WriteLine();
        }
    }

    class Civil_plane : Plane
    {
    public string Airlines {get;set;}
    public int Max_passengers {get;set;}
    public Civil_plane () {}
    public Civil_plane (string Name, int Weight_t, int Price_dollars, int Number_of_engines, int Max_flight_height_km, string Airlines, int Max_passengers) : base(Name, Weight_t, Price_dollars, Number_of_engines, Max_flight_height_km)
    {
    this.Airlines = Airlines;
    this.Max_passengers = Max_passengers;
    }

    public void InfoCivilPlane()
        {
        System.Console.WriteLine($"Name: {Name};\nWeight: {Weight_t};\nPrice: {Price_dollars};\nNumber of engines: {Number_of_engines};\nMaximum flight height in kilometers: {Max_flight_height_km};\nName of the airlines: {Airlines};\nMaximum number of passengers: {Max_passengers}.");
        System.Console.WriteLine();
        }
    }

    class Transport_plane : Plane
    {
    public int Max_personnel {get;set;}
    public bool Travel_overseas {get;set;}
    public Transport_plane () {}
    public Transport_plane (string Name, int Weight_t, int Price_dollars, int Number_of_engines, int Max_flight_height_km, int Max_personnel, bool Travel_overseas) : base (Name, Weight_t, Price_dollars, Number_of_engines, Max_flight_height_km)
     {
    this.Max_personnel = Max_personnel;
    this.Travel_overseas = Travel_overseas;
     }

    public void InfoTransportPlane()
        {
        System.Console.WriteLine($"Name: {Name};\nWeight: {Weight_t};\nPrice: {Price_dollars};\nNumber of engines: {Number_of_engines};\nMaximum flight height in kilometers: {Max_flight_height_km};\nMaximum number of personnel: {Max_personnel};\nIs travel overseas possible? {Travel_overseas}.");
        System.Console.WriteLine();
        }
    }
    


}
